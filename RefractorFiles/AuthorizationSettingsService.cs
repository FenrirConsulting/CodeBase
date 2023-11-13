using HeimdallCloud.Infrastructure.Shared.DataAccess.Data;
using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class AuthorizationSettingsService : IAuthorizationSettingsService
    {
        #region Services
        private readonly ApplicationDbContext dbContext;
        private readonly AuthorizationSettings _authorizationSettings;
        #endregion

        #region Methods
        public AuthorizationSettingsService(ApplicationDbContext dbContext, AuthorizationSettings authorizationSettings)
        {
            this.dbContext = dbContext;
            _authorizationSettings = authorizationSettings;
        }
        #endregion

        #region Functions
        public async Task LoadAuthorizationSettingsFromDatabase()
        {
            // Load the authorization settings from the database and populate the AuthorizationSettings object
            var settings = await dbContext.IAMHAuthorizationSettings.ToListAsync();
            _authorizationSettings.PopulateSettings(settings);
        }
        #endregion
    }
}
