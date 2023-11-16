using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.PowerBI.Api;
using Microsoft.PowerBI.Api.Models;
using Microsoft.Rest;

namespace HeimdallCloud.Shared.Services
{
    public class PowerBiServiceAPI
        (IConfiguration configuration, ITokenService tokenService, ILogger<PowerBiServiceAPI> logger) : IPowerBiServiceAPI
    {
        #region Services
        [Inject]
        private ITokenService? _TokenService { get; set; } = tokenService;

        private readonly ILogger _logger = logger;
        #endregion

        #region Properties
        private readonly string? _workspaceId = configuration["PowerBiAPI:WorkspaceId"];
        private string urlPowerBiServiceApiRoot { get; set; } = configuration["PowerBiAPI:ServiceRootUrl"]!;
        public string? CurrentPowerBiToken { get; set; }
        public EmbeddedReportViewModel EmbeddedReportViewModel { get; set; } = new();
        #endregion

        #region Functions
        // Create the Bi Client using Access Token
        public async Task<PowerBIClient> GetPowerBiClient()
        {
            var accessToken = await _TokenService!.AcquirePowerBiServicePrincipalTokenAsync();
            var tokenCredentials = new TokenCredentials(accessToken, "Bearer");
            CurrentPowerBiToken = accessToken;
            return new PowerBIClient(new Uri(urlPowerBiServiceApiRoot), tokenCredentials);
        }

        // Create the Embed Configuration using PowerBi Client and ReportId Parameter
        public async Task<EmbeddedReportViewModel> GetReportEmbedConfig(string reportId)
        {
            try
            {
                if (!Guid.TryParse(_workspaceId, out Guid workspaceGuid) || !Guid.TryParse(reportId, out Guid reportGuid))
                {
                    // Handle the case where the provided ID's are not valid Guids
                    throw new ArgumentException("Invalid workspaceId or reportId.");
                }

                PowerBIClient pbiClient = await GetPowerBiClient();
                var report = await pbiClient.Reports.GetReportAsync(workspaceGuid, reportGuid);

                var generateTokenRequestParameters = new GenerateTokenRequest(TokenAccessLevel.View, report.DatasetId);

                var tokenResponse = await pbiClient.Reports.GenerateTokenAsync(workspaceGuid, reportGuid, generateTokenRequestParameters);

                string embedToken = tokenResponse.Token.ToString();

                string srcBuilt = $"{report.EmbedUrl}&accessToken={Uri.EscapeDataString(embedToken)}";

                var embedReport = new EmbeddedReportViewModel
                {
                    Id = report.Id.ToString(),
                    EmbedUrl = report.EmbedUrl,
                    Name = report.Name,
                    EmbedToken = embedToken,
                    IFrameSRC = srcBuilt
                };

                EmbeddedReportViewModel = embedReport;

                return embedReport;
            }
            catch (HttpOperationException ex)
            {
                _logger.LogError(ex, "PowerBIAPI Error");

                if (ex.Response?.Content != null)
                {
                    string responseContent = ex.Response.Content;
                    _logger.LogError($"Reponse Content: {responseContent}");
                }

                if (ex.InnerException != null)
                {
                    _logger.LogError($"Inner Exception: {ex.InnerException.Message}");
                }

                var embedReport = new EmbeddedReportViewModel();
                return embedReport;
            }

        }
        #endregion
    }
}
