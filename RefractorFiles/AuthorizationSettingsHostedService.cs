using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class AuthorizationSettingsHostedService : IHostedService
    {
        #region Services & Delegates
        private readonly IServiceProvider? _serviceProvider;
        private readonly ILogger<AuthorizationSettingsHostedService> _logger;
        private readonly AuthorizationSettings _authorizationSettings;
        #endregion

        #region Methods
        public AuthorizationSettingsHostedService(IServiceProvider serviceProvider,
            ILogger<AuthorizationSettingsHostedService> logger,
            AuthorizationSettings authorizationSettings)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
            _authorizationSettings = authorizationSettings;
        }
        #endregion

        #region Functions
        // Singleton Hosted Authorization Service. Holds definitions from Database for Authorization Policies and Roles. 
        // Requires an application restart to change settings.
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider!.CreateScope())
            {
                var settingsService = scope.ServiceProvider.GetRequiredService<IAuthorizationSettingsService>();

                try
                {
                    await settingsService.LoadAuthorizationSettingsFromDatabase();
                    var options = scope.ServiceProvider.GetRequiredService<IOptions<AuthorizationOptions>>().Value;

                    // Policies based on Policy Settings
                    if (_authorizationSettings.Policies != null)
                    {
                        foreach (var policy in _authorizationSettings.Policies)
                        {
                            options.AddPolicy(policy.Key, p => p.Requirements.Add(new GroupRequirement(policy.Value)));
                        }

                    }

                    // Policies based on Role Settings
                    if (_authorizationSettings.Roles != null)
                    {
                        foreach (var role in _authorizationSettings.Roles)
                        {
                            options.AddPolicy(role.Key, r => r.Requirements.Add(new GroupRequirement(role.Value)));
                        }
                    }

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occured while setting up authorization policies.");
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        #endregion
    }
}
