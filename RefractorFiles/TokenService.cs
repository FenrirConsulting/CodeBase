using HeimdallCloud.Shared.Models;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using HeimdallCloud.Shared.Common;
using HeimdallCloud.Shared.Services.IServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace HeimdallCloud.Shared.Services
{
    public class TokenService(ITokenAcquisition tokenAcquisition, IConfiguration configuration, IOptions<AzureAd> azureAd,
       IGraphServiceAPI graphServiceApi, IUserSessionService userSessionService
           ) : ITokenService
    {
        #region Services
        private readonly ITokenAcquisition _tokenAcquisition = tokenAcquisition;
        private readonly IConfiguration _configuration = configuration;
        private readonly IOptions<AzureAd> _azureAd = azureAd;
        private readonly IGraphServiceAPI _graphServiceApi = graphServiceApi;
        private readonly IUserSessionService _userSessionService = userSessionService;
        #endregion

        #region Properties
        public string? CurrentGraphToken { get; set; }
        public string? CurrentPowerBiToken { get; set; }
        public string? CurrentPowerBiServicePrincipalToken { get; set; }
        public string? CurrentToken { get; set; }

        public string? CurrentUID
        {
            get => _userSessionService.CurrentUID;
            set => _userSessionService.CurrentUID = value!;
        }

        public string? CurrentUserDisplayName
        {
            get => _userSessionService.CurrentUserDisplayName;
            set => _userSessionService.CurrentUserDisplayName = value!;
        }

        public List<string>? UserGroupNames
        {
            get => _userSessionService.UserGroupNames;
            set => _userSessionService.UserGroupNames = value!;
        }

        public List<string>? AuthorizedPolicies
        {
            get => _userSessionService.AuthorizedPolicies;
            set => _userSessionService.AuthorizedPolicies = value!;
        }

        #endregion

        #region Functions
        // Set Current Display Name using current UID and Graph API
        public async Task<bool> SetCurrentUserDisplayName()
        {
            bool nameCheck = false;
            Microsoft.Graph.Models.User Me = await _graphServiceApi!.GetUserInformation(CurrentUID!);
            if (Me.DisplayName != null)
            {
                CurrentUserDisplayName = Me.DisplayName;
                nameCheck = true;
            }
            return nameCheck;
        }

        // Initial Load of Security Groups, Called after Succesful Token Validation. Initializes Authorization Settings Dictionary as Well
        public async Task InitializeUserGroups(ClaimsPrincipal user)
        {
            if (user.Identity!.IsAuthenticated)
            {
                var userId = user.FindFirst("uid")?.Value;
                if (!string.IsNullOrEmpty(userId) && (UserGroupNames == null || UserGroupNames.Count == 0))
                {
                    CurrentUID = userId;
                    Microsoft.Graph.Models.User Me = await _graphServiceApi!.GetUserInformation(CurrentUID!);
                    CurrentUserDisplayName = Me.DisplayName;
                    await RetrieveAndStoreGroupIds(userId);
                }
            }
        }

        // Load the UserGroupNames list from all Group Id's Authenticated User is a Direct Member Of
        public async Task RetrieveAndStoreGroupIds(string userId)
        {
            DirectoryObjectCollectionResponse groupObjects = await _graphServiceApi.GetUserGroupMemberships(userId);
            var groupNames = new List<string>();

            foreach (DirectoryObject directoryObject in groupObjects!.Value!)
            {
                if (directoryObject is Group group)
                {
                    groupNames!.Add(group!.DisplayName!);
                }
            }

            UserGroupNames = groupNames;
        }

        // Current User Token with Default Scopes
        public async Task<string> AcquireTokenAsync(string[] scopes)
        {
            try
            {
                CurrentToken = await _tokenAcquisition.GetAccessTokenForUserAsync(scopes);
                return CurrentToken;
            }
            catch (MsalUiRequiredException)
            {
                throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
            }
            catch (MicrosoftIdentityWebChallengeUserException)
            {
                throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
            }
        }

        // Current User Token with Graph API Scopes
        public async Task<string> AcquireGraphTokenAsync(string UserId)
        {
            try
            {
                string[] graphScopes = _configuration.GetValue<string>("GraphAPI:Scopes")?.Split(' ')!;
                CurrentGraphToken = await _tokenAcquisition.GetAccessTokenForUserAsync(graphScopes);
                CurrentUID = UserId;
                return CurrentGraphToken;
            }
            catch (MsalUiRequiredException)
            {
                throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
            }
            catch (MicrosoftIdentityWebChallengeUserException)
            {
                throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
            }
        }

        // Current User Token with PowerBi API Scopes
        public async Task<string> AcquirePowerBiTokenAsync()
        {
            try
            {
                var readWriteScope = _configuration["PowerBiAPI:PowerBIScopes:WorkspaceReadWrite"];
                var readScope = _configuration["PowerBiAPI:PowerBIScopes:WorkspaceRead"];

                CurrentPowerBiToken = await _tokenAcquisition.GetAccessTokenForUserAsync(new[] { readWriteScope, readScope }!);
                return CurrentPowerBiToken;
            }
            catch (MsalUiRequiredException)
            {
                throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
            }
            catch (MicrosoftIdentityWebChallengeUserException)
            {
                throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
            }
        }

        // Service Principal User Token for PowerBi API Scopes Async
        public async Task<string> AcquirePowerBiServicePrincipalTokenAsync()
        {
            try
            {
                AuthenticationResult authenticationResult = null!;

                var tenantSpecificUrl = _azureAd.Value.AuthorityUrl!.Replace("organizations", _azureAd.Value.TenantId);

                // Create a confidential client to authorize the app with the AAD app
                IConfidentialClientApplication clientApp = ConfidentialClientApplicationBuilder
                                                                                .Create(_azureAd.Value.ClientId)
                                                                                .WithClientSecret(_azureAd.Value.ClientSecret)
                                                                                .WithAuthority(tenantSpecificUrl)
                                                                                .Build();

                authenticationResult = clientApp.AcquireTokenForClient(_azureAd.Value.ScopeBase).ExecuteAsync().Result;

                return authenticationResult.AccessToken;
            }
            catch (MsalUiRequiredException)
            {
                throw new CustomInteractiveSignInRequiredException("SP Token Retrieval Failed.");
            }
            catch (MicrosoftIdentityWebChallengeUserException)
            {
                throw new CustomInteractiveSignInRequiredException("SP Token Retrieval Failed.");
            }
        }

        // Service Principal User Token for PowerBi API Scopes Non-Async
        public string AcquirePowerBiServicePrincipalToken()
        {
            try
            {
                AuthenticationResult authenticationResult = null!;

                var tenantSpecificUrl = _azureAd.Value.AuthorityUrl!.Replace("organizations", _azureAd.Value.TenantId);

                // Create a confidential client to authorize the app with the AAD app
                IConfidentialClientApplication clientApp = ConfidentialClientApplicationBuilder
                                                                                .Create(_azureAd.Value.ClientId)
                                                                                .WithClientSecret(_azureAd.Value.ClientSecret)
                                                                                .WithAuthority(tenantSpecificUrl)
                                                                                .Build();

                authenticationResult = clientApp.AcquireTokenForClient(_azureAd.Value.ScopeBase).ExecuteAsync().Result;

                return authenticationResult.AccessToken;
            }
            catch (MsalUiRequiredException)
            {
                throw new CustomInteractiveSignInRequiredException("SP Token Retrieval Failed.");
            }
            catch (MicrosoftIdentityWebChallengeUserException)
            {
                throw new CustomInteractiveSignInRequiredException("SP Token Retrieval Failed.");
            }
        }
        #endregion
    }
}
