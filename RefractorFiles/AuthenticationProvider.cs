using HeimdallCloud.Shared.Models;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class AuthenticationProvider(IOptions<AzureAd> azureAd) : IAccessTokenProvider
    {
        #region Services
        private readonly IOptions<AzureAd>? _azureAd = azureAd;
        private IConfidentialClientApplication? _app;
        public AllowedHostsValidator AllowedHostsValidator { get; }
        #endregion

        #region Functions
        private IConfidentialClientApplication BuildApp()
        {
            if (_app != null)
            {
                return _app;
            }

            _app = ConfidentialClientApplicationBuilder.Create(_azureAd!.Value.ClientId)
                .WithClientSecret(_azureAd.Value.ClientSecret)
                .WithAuthority(AzureCloudInstance.AzurePublic, _azureAd.Value.TenantId)
                .Build();

            return _app;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            IConfidentialClientApplication app = BuildApp();
            string[] scopes = ["https://graph.microsoft.com/.default"];

            AuthenticationResult result = await app.AcquireTokenForClient(scopes).ExecuteAsync();
            return result.AccessToken;
        }

        public async Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object>? additionalAuthenticationContext = default,
         CancellationToken cancellationToken = default)
        {
            var token = await GetAccessTokenAsync();
            string tokenString = token.ToString()!;
            return tokenString;
        }
        #endregion
    }
}
