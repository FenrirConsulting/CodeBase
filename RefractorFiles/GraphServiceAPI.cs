using HeimdallCloud.Shared.Models;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Authentication;

namespace HeimdallCloud.Shared.Services
{
    public class GraphServiceAPI(IOptions<AzureAd> azureAd, IAccessTokenProvider authenticationProvider) : IGraphServiceAPI
    {
        #region Services & Delegates
        private const string GraphEndpoint = "https://graph.microsoft.com/v1.0/";
        private readonly string[] scopes = ["https://graph.microsoft.com/.default"];

        private readonly IOptions<AzureAd> _azureAd = azureAd;
        private readonly IAccessTokenProvider _authenticationProvider = authenticationProvider;
        #endregion

        #region Properties
        public List<string> UserGroups { get; private set; } = [];
        #endregion

        #region Functions
        public async Task<GraphServiceClient> CreateGraphClient()
        {
            var authenticationProvider = new BaseBearerTokenAuthenticationProvider(_authenticationProvider!);
            var graphServiceClient = new GraphServiceClient(authenticationProvider);
            return graphServiceClient;
        }

        // Return Me object of passed UserId
        public async Task<User> GetUserInformation(string userId)
        {
            GraphServiceClient graphClient = await CreateGraphClient();
            var me = await graphClient.Users[userId].GetAsync();
            return me!;
        }

        // Return List of Groups User ID Belongs To
        public async Task<List<string>> GetUserGroupMemberships(string userId)
        {
            GraphServiceClient graphClient = await CreateGraphClient();
            var groupObjects = await graphClient.Users[userId].MemberOf.GetAsync();
            var groupNames = new List<string>();

            foreach (DirectoryObject directoryObject in groupObjects!.Value!)
            {
                if (directoryObject is Group group)
                {
                    groupNames!.Add(group!.DisplayName!);
                }
            }

            return groupNames;
        }
        #endregion
    }
}