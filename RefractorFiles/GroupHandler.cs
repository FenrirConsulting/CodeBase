using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class GroupHandler : AuthorizationHandler<GroupRequirement>
    {
        private readonly IUserGroupService _userGroupService;

        public GroupHandler(IUserGroupService userGroupService)
        {
            _userGroupService = userGroupService;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, GroupRequirement requirement)
        {
            foreach (var group in requirement.GroupNames)
            {
                if (await _userGroupService.IsUserInGroupAsync(group))
                {
                    context.Succeed(requirement);
                }
            }

            foreach (var group in requirement.GroupDisplayNames)
            {
                if (await _userGroupService.IsUserDisplayName(group))
                {
                    context.Succeed(requirement);
                }
            }
        }
    }
}
