using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.Repositories;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Security.Principal;


namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell.Components.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] public IAppConfiguration? AppConfiguration { get; set; }
        [Inject] public AuthenticationStateProvider? AuthenticationStateProvider { get; set; }
        [Inject] public IDomainUserGroupService? _DomainUserGroupService { get; set; }
        [Inject] public IUserSettingsRepository? _UserSettingsRepository { get; set; }
        [Inject] ILogHelper? _Logger { get; set; }
        [Inject] LdapRoleMappingConfig? LdapRoleMappingConfig { get; set; }

        private string? databaseDisplayName;
        private string? userDisplayName;
        private List<string>? userGroups;
        private List<string>? userRoles;
        private List<string>? ldapRoleMappings;

        protected override async Task OnInitializedAsync()
        {
            var authenticationState = await AuthenticationStateProvider!.GetAuthenticationStateAsync();
            var user = authenticationState.User;

            if (user.Identity!.IsAuthenticated)
            {
                try
                {
                    userDisplayName = user.Identity.Name;
                    userGroups = UserGroupsCache.GetUserGroups(userDisplayName!);

                    var identityRoles = user.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value)
                        .ToList();
                    userRoles = identityRoles;

                    ldapRoleMappings = LdapRoleMappingConfig!.LdapRoleMappings.Keys.ToList();

                    var userSettings = await _UserSettingsRepository!.GetUserSAMAsync(userDisplayName!);
                    databaseDisplayName = userSettings?.UserName;
                }
                catch (Exception ex)
                {
                    _Logger!.LogError("Error getting user settings: {0}", ex);
                }
            }
        }
    }
}
