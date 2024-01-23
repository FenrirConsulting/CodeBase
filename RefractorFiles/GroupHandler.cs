using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class GroupHandler(IUserSessionService userSessionService) : AuthorizationHandler<GroupRequirement>
    {
        #region Services
        private readonly IUserSessionService _userSessionService = userSessionService;
        #endregion

        #region Functions
        // Checks against if current user User Groups contains a passed group, or if the CUrrent Uesr matches a Current User ID.
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, GroupRequirement requirement)
        {
            foreach (var group in requirement.GroupNames)
            {
                if (await IsUserInGroupAsync(group))
                {
                    context.Succeed(requirement);
                }
            }

            foreach (var group in requirement.GroupDisplayNames)
            {
                if (await IsUserDisplayName(group))
                {
                    context.Succeed(requirement);
                }
            }
        }

        //Check passed in Group Name for a match to return back to the Group Handler.
        public Task<bool> IsUserInGroupAsync(string groupName)
        {
            var userGroups = _userSessionService.UserGroupNames;
            if (userGroups == null)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(userGroups.Contains(groupName));
        }

        // Check Passed in Display Name for a match to return back to the Group Handler.
        public Task<bool> IsUserDisplayName(string displayName)
        {
            bool isMatch = string.Equals(displayName, _userSessionService.CurrentUserDisplayName, StringComparison.OrdinalIgnoreCase);
            return Task.FromResult(isMatch);
        }
        #endregion
    }
}
