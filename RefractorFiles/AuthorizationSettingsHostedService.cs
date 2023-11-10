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
        private readonly IServiceProvider? _serviceProvider;
        private readonly AuthorizationSettings _authorizationSettings;

        public AuthorizationSettingsHostedService(IServiceProvider serviceProvider, AuthorizationSettings authorizationSettings)
        {
            _serviceProvider = serviceProvider;
            _authorizationSettings = authorizationSettings;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider!.CreateScope();
            var settingsService = scope.ServiceProvider.GetRequiredService<IAuthorizationSettingsService>();
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

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
