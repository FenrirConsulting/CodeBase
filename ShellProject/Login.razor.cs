using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using MudBlazor;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Navigation;
using Microsoft.AspNetCore.Authentication.Negotiate;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using Microsoft.AspNetCore.Components.Web;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using Newtonsoft.Json;
using System.Text;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication;

namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell.Components.Account.Pages
{
    public partial class Login : ComponentBase
    {
        // Injecting dependencies
        [Inject] ILdapAuthenticationService? _LdapAuthenticationService { get; set; }
        [Inject] LdapServerList? _LdapServerList { get; set; }
        [Inject] NavigationManager? _NavigationManager { get; set; }
        [Inject] IdentityRedirectManager? _RedirectManager { get; set; }
        [Inject] AuthenticationStateProvider? _AuthenticationStateProvider { get; set; }
        [Inject] IClaimsTransformation? _ClaimsTransform { get; set; }
        [Inject] IRequestRefresh? _RequestRefresh { get; set; }
        [Inject] ILogHelper? _LogHelper { get; set; }
        [Inject] RoleUpdateRequest? _RoleUpdateRequest { get; set; }
        [Inject] IHttpClientFactory? _HttpClientFactory { get; set; }
        [Inject] IAppConfiguration? _AppConfiguration { get; set; }
        [Inject] CookieHandler? _CookieHandler { get; set; }
        [Inject] IHttpContextAccessor? _HttpContextAccessor { get; set; }

        // Binding the login model to the form
        [SupplyParameterFromForm]
        private LoginModel loginModel { get; set; } = new LoginModel();

        private MudForm? form { get; set; }

        private bool showErrorMessage = false;
        private string errorMessage = "";

        private bool showSuccessMessage = false;
        private string successMessage = "";

        string CurrentUserName = "";

        protected override async Task OnInitializedAsync()
        {
            // Get the current authentication state
            var authenticationState = await _AuthenticationStateProvider!.GetAuthenticationStateAsync();
            var user = authenticationState.User;
            CurrentUserName = user.Identity?.Name ?? "Anonymous";
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
            var selectedServer = _LdapServerList?.Servers.FirstOrDefault(s => s.Server == loginModel.SelectedServer);

            if (selectedServer != null && _LdapAuthenticationService != null)
            {
                try
                {
                    // Validate the user credentials and fetch roles from LDAP server
                    var (isAuthenticated, roles) = await _LdapAuthenticationService.ValidateCredentialsAndFetchRolesAsync(
                        selectedServer.Name!,
                        selectedServer.Server!,
                        selectedServer.Port,
                        selectedServer.SearchBase!,
                        selectedServer.AdminSearchBase!,
                        loginModel.Username,
                        loginModel.Password
                    );

                    if (isAuthenticated)
                    {
                        // Add user roles to the cache
                        //UserGroupsCache.AddUserRoles(CurrentUserName, roles);
                        _RoleUpdateRequest!.Roles = roles;

                        var httpClient = _HttpClientFactory!.CreateClient(_AppConfiguration!.CookieName);

                        var jsonContent = JsonConvert.SerializeObject(_RoleUpdateRequest);
                        var content = new StringContent(jsonContent, encoding: Encoding.UTF8 , "application/json");

                        var oldClaims = _HttpContextAccessor!.HttpContext!.User.Claims.ToList();
                        var oldClaimsString = string.Join(", ", oldClaims);
                        _LogHelper!.LogMessage(oldClaimsString);

                        var response = await httpClient.PostAsync($"{_AppConfiguration!.AuthenticationAPIURL}updateRoles", content);
                        bool responseCode = response.IsSuccessStatusCode;

                        // Get the updated authentication state
                        var authenticationState = await _AuthenticationStateProvider!.GetAuthenticationStateAsync();
                        var user = authenticationState.User;

                        // Transform the user claims
                        await _ClaimsTransform!.TransformAsync(user);


                        var newClaims = _HttpContextAccessor!.HttpContext!.User.Claims.ToList();
                        var newClaimsString = string.Join(", ", newClaims);
                        _LogHelper!.LogMessage(newClaimsString);


                        if (roles.Any() && responseCode == true)
                        {
                            showSuccessMessage = true;
                            successMessage = "Added Roles: " + string.Join(", ", roles);

                            _RequestRefresh!.CallRequestRefresh();

                            _LogHelper!.LogMessage("Logged In User " + CurrentUserName);
                        }
                        else
                        {
                            showErrorMessage = true;
                            errorMessage = "Access Denied. No Roles Added.";
                        }
                    }
                    else
                    {
                        showErrorMessage = true;
                        errorMessage = "Invalid username or password. Please try again.";
                    }
                }
                catch (Exception ex)
                {
                    showErrorMessage = true;
                    errorMessage = ex.Message.Contains("Failed to connec") ? "Invalid Server Name" : ex.Message;
                    _LogHelper!.LogError(ex.Message, ex);
                }
            }
            else
            {
                showErrorMessage = true;
                errorMessage = "Select a Domain for Login.";
            }
        }
    }
}
