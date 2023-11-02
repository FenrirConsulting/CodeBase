using HeimdallCloud.Shared.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class UserGroupService : IUserGroupService
    {
        private readonly IUserSessionService _userSessionService;

        public UserGroupService(IUserSessionService userSessionService)
        {
            _userSessionService = userSessionService;
        }   

        public Task<bool> IsUserInGroupAsync(string groupName)
        {
            var userGroups = _userSessionService.UserGroupNames;
            return Task.FromResult(userGroups!.Contains(groupName));
        }

        public Task<bool> IsUserDisplayName(string displayName)
        {
            bool isMatch = string.Equals(displayName, _userSessionService.CurrentUserDisplayName, StringComparison.OrdinalIgnoreCase);
            return Task.FromResult(isMatch);
        }
    }
}
