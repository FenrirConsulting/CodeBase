using Microsoft.AspNetCore.Components;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using Microsoft.AspNetCore.Authentication;
using MudBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Navigation;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using Microsoft.AspNetCore.Components.Web;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using System.Text;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell.Components.Account.Pages
{
    public partial class Login : ComponentBase
    {
        // Injecting dependencies
        [Inject] ILdapAuthenticationService? _LdapAuthenticationService { get; set; }
        [Inject] LdapServerList? _LdapServerList { get; set; }
        [Inject] NavigationManager? _NavigationManager { get; set; }
        [Inject] AuthenticationStateProvider? _AuthenticationStateProvider { get; set; }
        [Inject] IClaimsTransformation? _ClaimsTransform { get; set; }
        [Inject] IRequestRefresh? _RequestRefresh { get; set; }
        [Inject] ILogHelper? _LogHelper { get; set; }
        [Inject] RoleUpdateRequest? _RoleUpdateRequest { get; set; }
        [Inject] IHttpClientFactory? _HttpClientFactory { get; set; }
        [Inject] IAppConfiguration? _AppConfiguration { get; set; }
        [Inject] private IDistributedCache? _Cache { get; set; }

        // Binding the login model to the form
        [SupplyParameterFromForm]
        private LoginModel loginModel { get; set; } = new LoginModel();

        private MudForm? form { get; set; }

        private bool showErrorMessage = false;
        private string errorMessage = "";

        private bool showSuccessMessage = false;
        private string successMessage = "";

        private bool _isLoading = false;

        string CurrentUserName = "";

        protected override async Task OnInitializedAsync()
        {
            // Get the current authentication state
            var authState = await _AuthenticationStateProvider!.GetAuthenticationStateAsync();
            CurrentUserName = authState.User.Identity?.Name ?? "Anonymous";
        }

        private async Task HandleEnterKeyPress(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                await HandleLogin();
            }
        }

        private async Task HandleLogin()
        {
            // Find the selected LDAP server
            _isLoading = true;
            var selectedServer = _LdapServerList?.Servers.FirstOrDefault(s => s.Server == loginModel.SelectedServer);

            if (selectedServer == null || _LdapAuthenticationService == null)
            {
                showErrorMessage = true;
                errorMessage = "Select a Domain for Login.";
                _isLoading = false;
                return;
            }

            try
            {
                var (isAuthenticated, roles) = await _LdapAuthenticationService.ValidateCredentialsAndFetchRolesAsync(
                    selectedServer.Name!,
                    selectedServer.Server!,
                    selectedServer.Port,
                    selectedServer.SearchBase!,
                    selectedServer.AdminSearchBase!,
                    loginModel.Username,
                    loginModel.Password
                );

                if (!isAuthenticated)
                {
                    showErrorMessage = true;
                    errorMessage = "Invalid username or password. Please try again.";
                    _isLoading = false;
                    return;
                }

                _RoleUpdateRequest!.Roles = roles;

                var httpClient = _HttpClientFactory!.CreateClient(_AppConfiguration!.CookieName);
                var jsonContent = JsonSerializer.Serialize(_RoleUpdateRequest);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"{_AppConfiguration!.AuthenticationAPIURL}updateRoles", content);

                if (!response.IsSuccessStatusCode)
                {
                    showErrorMessage = true;
                    errorMessage = "Failed to update roles.";
                    _isLoading = false;
                    return;
                }

                // Update local cache
                await _Cache!.SetStringAsync(
                    $"user_roles_{CurrentUserName}",
                    JsonSerializer.Serialize(roles),
                    new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_AppConfiguration.CookieTimeout)
                    }
                );

                var authenticationState = await _AuthenticationStateProvider!.GetAuthenticationStateAsync();
                var user = authenticationState.User;

                showSuccessMessage = true;
                successMessage = "Added Roles: " + string.Join(", ", roles);
                _LogHelper!.LogMessage($"Updated roles for user {CurrentUserName}");

                _RequestRefresh!.CallRequestRefresh();

                _isLoading = false;
            }
            catch (Exception ex)
            {
                showErrorMessage = true;
                errorMessage = ex.Message.Contains("Failed to connect") ? "Invalid Server Name" : ex.Message;
                _LogHelper!.LogError(ex.Message, ex);
                _isLoading = false;
            }

        }
    }
}
