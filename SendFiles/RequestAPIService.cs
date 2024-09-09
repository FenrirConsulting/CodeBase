using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Services
{
    /// <summary>
    /// Provides services for making API requests related to enable/disable operations.
    /// </summary>
    public class RequestAPIService
    {
        #region Fields

        private readonly IAppConfiguration _appConfiguration;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAPIService"/> class.
        /// </summary>
        /// <param name="appConfiguration">The application configuration.</param>
        public RequestAPIService(IAppConfiguration appConfiguration)
        {
            _appConfiguration = appConfiguration ?? throw new ArgumentNullException(nameof(appConfiguration));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Posts a request message to the IAPF API.
        /// </summary>
        /// <param name="token">The authentication token.</param>
        /// <param name="requestBodyJson">The request body in JSON format.</param>
        /// <returns>An <see cref="IAPFResponse"/> object.</returns>
        public IAPFResponse PostRequestMessage(string token, string requestBodyJson)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("Token cannot be null or empty.", nameof(token));

            if (string.IsNullOrEmpty(requestBodyJson))
                throw new ArgumentException("Request body JSON cannot be null or empty.", nameof(requestBodyJson));

            string iapfRequestURL = _appConfiguration.DynamicValues["RequestAPIURL"];

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", requestBodyJson, ParameterType.RequestBody);

            var client = new RestClient(iapfRequestURL);
            var response = client.Execute(request);

            if (response?.StatusCode == System.Net.HttpStatusCode.OK && !string.IsNullOrEmpty(response.Content))
            {
                return JsonConvert.DeserializeObject<IAPFResponse>(response.Content) ?? new IAPFResponse();
            }

            // Consider logging the error or throwing an exception here
            return new IAPFResponse();
        }

        /// <summary>
        /// Gets an access token for authentication.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <param name="secretValue">The client secret.</param>
        /// <param name="tenantId">The tenant ID.</param>
        /// <returns>An access token string.</returns>
        public async Task<string> GetAccessToken(string clientId, string secretValue, string tenantId)
        {
            if (string.IsNullOrEmpty(clientId))
                throw new ArgumentException("Client ID cannot be null or empty.", nameof(clientId));

            if (string.IsNullOrEmpty(secretValue))
                throw new ArgumentException("Secret value cannot be null or empty.", nameof(secretValue));

            if (string.IsNullOrEmpty(tenantId))
                throw new ArgumentException("Tenant ID cannot be null or empty.", nameof(tenantId));

            var app = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithClientSecret(secretValue)  // Once AKeyLess is working, can set to ServicePrincipalAKeylessKey
                .WithAuthority(new Uri($"https://login.microsoftonline.com/{tenantId}"))
                .Build();

            var result = await app.AcquireTokenForClient(new[] { "https://graph.microsoft.com/.default" })
                .ExecuteAsync();

            return result.AccessToken;
        }

        #endregion
    }
}