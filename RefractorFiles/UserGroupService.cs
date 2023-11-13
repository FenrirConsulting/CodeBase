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
        #region Services
        private readonly IUserSessionService _userSessionService;
        #endregion

        #region Methods
        public UserGroupService(IUserSessionService userSessionService)
        {
            _userSessionService = userSessionService;
        }
        #endregion

        #region Functions
        //Both functions service to check passed in Group Name or Display Name for a match to return back to the Group Handler.
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
        #endregion
    }
}
