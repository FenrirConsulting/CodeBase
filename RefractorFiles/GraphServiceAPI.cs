using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Identity.Client;
using Microsoft.Kiota.Abstractions.Authentication;

namespace HeimdallCloud.Shared.Services
{
    public class GraphServiceAPI : IGraphServiceAPI
    {
        #region Services & Delegates
        private const string GraphEndpoint = "https://graph.microsoft.com/v1.0/";
        private string[] scopes = new[] { "https://graph.microsoft.com/.default" };

        private readonly IOptions<AzureAd> _azureAd;
        private IConfidentialClientApplication? _app;
        private readonly IAccessTokenProvider _authenticationProvider;
        #endregion

        #region Properties
        public List<string> UserGroups { get; private set; } = new();
        #endregion

        #region Methods
        public GraphServiceAPI(IOptions<AzureAd> azureAd, IAccessTokenProvider authenticationProvider)
        {
            _azureAd = azureAd;
            _authenticationProvider = authenticationProvider;
        }
        #endregion

        #region Functions
        public async Task<GraphServiceClient> CreateGraphClient()
        {
            var authenticationProvider = new BaseBearerTokenAuthenticationProvider(_authenticationProvider!);
            var graphServiceClient = new GraphServiceClient(authenticationProvider);
            return graphServiceClient;
        }

        public async Task<User> GetUserInformation(string userId)
        {
            GraphServiceClient graphClient = await CreateGraphClient();
            var me = await graphClient.Users[userId].GetAsync();
            return me!;
        }

        public async Task<DirectoryObjectCollectionResponse> GetUserGroupMemberships(string userId)
        {
            GraphServiceClient graphClient = await CreateGraphClient();
            var groupObjects = await graphClient.Users[userId].MemberOf.GetAsync();
            return groupObjects!;
        }
        #endregion
    }
}