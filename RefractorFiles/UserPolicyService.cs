using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class UserPolicyService : IUserPolicyService
    {
        #region Services
        private readonly IAuthorizationService _authorizationService;
        private readonly AuthorizationSettings _authorizationSettings;
        #endregion

        #region Methods
        public UserPolicyService(IAuthorizationService authorizationService, AuthorizationSettings authorizationSettings)
        {
            _authorizationService = authorizationService;
            _authorizationSettings = authorizationSettings;
        }
        #endregion

        #region Functions
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
    }
}
