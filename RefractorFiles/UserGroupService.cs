using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HeimdallCloud.Shared.Services
{
    public class UserGroupService(IUserSessionService userSessionService, IGraphServiceAPI graphServiceApi, 
        IAuthorizationService authorizationService, AuthorizationSettings authorizationSettings) : IUserGroupService
    {
        #region Services
        private readonly IUserSessionService _userSessionService = userSessionService;
        private readonly IGraphServiceAPI _graphServiceApi = graphServiceApi;
        private readonly IAuthorizationService _authorizationService = authorizationService;
        private readonly AuthorizationSettings _authorizationSettings = authorizationSettings;
        #endregion

        #region Functions
        // Set Current Display Name using current UID and Graph API
        public async Task<bool> SetCurrentUserDisplayName()
        {
            bool nameCheck = false;
            Microsoft.Graph.Models.User Me = await _graphServiceApi!.GetUserInformation(_userSessionService.CurrentUID!);
            if (Me.DisplayName != null)
            {
                SetUserDisplayName(Me.DisplayName);
                nameCheck = true;
            }
            return nameCheck;
        }

        // Load the UserGroupNames list from all Group Id's Authenticated User is a Direct Member Of
        public async Task<List<string>> GetGraphApiGroupNames(string userId)
        {
            var groupNames = await _graphServiceApi.GetUserGroupMemberships(userId);
            return groupNames;
        }

        // Set List of Authorized policies the User Belongs to
        public async Task<List<string>> GetAuthorizedPoliciesAsync(ClaimsPrincipal user)
        {
            var policyNames = new List<string>();

            foreach (var policy in _authorizationSettings.Policies!.Keys)
            {
                var authorizationResult = await _authorizationService!.AuthorizeAsync(user, null, policy);
                if (authorizationResult.Succeeded)
                {
                    policyNames.Add(policy);
                }
            }

            foreach (var role in _authorizationSettings.Roles!.Keys)
            {
                var authorizationResult = await _authorizationService!.AuthorizeAsync(user, null, role);
                if (authorizationResult.Succeeded)
                {
                    policyNames.Add(role);
                }
            }

            return policyNames;
        }
        #endregion

        #region Set User Session Scoped Properties
        public void SetUserUID(string UserId)
        {
            _userSessionService.CurrentUID = UserId;
        }

        public void SetUserDisplayName(string UserDisplayName)
        {
            _userSessionService.CurrentUserDisplayName = UserDisplayName;
        }

        public void SetUserGroupNames(List<string> UserGroups)
        {
            _userSessionService.UserGroupNames = UserGroups;
        }

        public void SetUserAuthorizedPolicies(List<string> AuthorizedPolicies)
        {
            _userSessionService.AuthorizedPolicies = AuthorizedPolicies;
        }

        public void SetCurentToken(string CurrentToken)
        {
            _userSessionService.CurrentToken = CurrentToken;
        }

        public void SetCurentGraphToken(string CurrentGraphToken)
        {
            _userSessionService.CurrentGraphToken = CurrentGraphToken;
        }

        public void SetCurrentPowerBiToken(string CurrentPowerBiToken)
        {
            _userSessionService.CurrentPowerBiToken = CurrentPowerBiToken;
        }

        public void SetCurrentPowerBiServicePrincipalToken(string CurrentPowerBiServicePrincipalToken)
        {
            _userSessionService.CurrentPowerBiServicePrincipalToken = CurrentPowerBiServicePrincipalToken;
        }
        #endregion
    }
}
