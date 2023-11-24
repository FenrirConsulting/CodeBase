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
using Microsoft.AspNetCore.Components.Authorization;

namespace HeimdallCloud.Shared.Services
{
    public class TokenService(ITokenAcquisition tokenAcquisition, IConfiguration configuration, IOptions<AzureAd> azureAd,
       IGraphServiceAPI graphServiceApi, IUserSessionService userSessionService, IUserGroupService userGroupService
           ) : ITokenService
    {
        #region Services
        private readonly ITokenAcquisition _tokenAcquisition = tokenAcquisition;
        private readonly IConfiguration _configuration = configuration;
        private readonly IOptions<AzureAd> _azureAd = azureAd;
        private readonly IGraphServiceAPI _graphServiceApi = graphServiceApi;
        private readonly IUserSessionService _userSessionService = userSessionService;
        private readonly IUserGroupService _userGroupService = userGroupService;
        #endregion

        #region Properties
        [CascadingParameter]
        private Task<AuthenticationState>? AuthenticationState { get; set; }

        // Properties set to User Session Service Values
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

        public string? CurrentToken
        {
            get => _userSessionService.CurrentToken;
            set => _userSessionService.CurrentToken = value!;
        }

        public string? CurrentGraphToken
        {
            get => _userSessionService.CurrentGraphToken;
            set => _userSessionService.CurrentGraphToken = value!;
        }

        public string? CurrentPowerBiToken
        {
            get => _userSessionService.CurrentPowerBiToken;
            set => _userSessionService.CurrentPowerBiToken = value!;
        }

        public string? CurrentPowerBiServicePrincipalToken
        {
            get => _userSessionService.CurrentPowerBiServicePrincipalToken;
            set => _userSessionService.CurrentPowerBiServicePrincipalToken = value!;
        }
        #endregion

        #region Functions

        // Initial Load of Security Groups, Called after Succesful Token Validation, Initializes Groups, User Settings, & Authorized Policies
        public async Task InitializeUserGroups(ClaimsPrincipal user)
        {
            if (user.Identity!.IsAuthenticated)
            {
                var userId = user.FindFirst("uid")?.Value;
                if (!string.IsNullOrEmpty(userId) && (UserGroupNames == null || UserGroupNames.Count == 0))
                {
                    _userGroupService.SetUserUID(userId);
                    Microsoft.Graph.Models.User Me = await _graphServiceApi!.GetUserInformation(userId);
                    _userGroupService.SetUserDisplayName(Me.DisplayName!);
                    _userGroupService.SetUserGroupNames(await _userGroupService.GetGraphApiGroupNames(userId));
                    _userGroupService.SetUserAuthorizedPolicies(await _userGroupService.GetAuthorizedPoliciesAsync(user));
                }
            }
        }

        // Refresh Token, Groups, Policies on Expiry
        public async Task RefreshToken(ClaimsPrincipal user)
        {
            if (user.Identity!.IsAuthenticated && (IsTokenNearExpiry() || (UserGroupNames == null || UserGroupNames.Count == 0)))
            {
                try
                {
                    string[] scopes = _configuration.GetValue<string>("GraphAPI:Scopes")?.Split(' ')!;
                    var newToken = await AcquireTokenAsync(scopes, user);

                    // Refresh Graph API Token
                    var userId = user.FindFirst("uid")?.Value;
                    await AcquireGraphTokenAsync(userId!);

                    // Refresh Groups List
                    await InitializeUserGroups(user);
                }
                catch (MsalUiRequiredException)
                {
                    throw new CustomInteractiveSignInRequiredException("Interactive Sign-In Required");
                }

            }
        }

        // Bool check for Token Expiration Time
        public bool IsTokenNearExpiry()
        {
            // Returns True if the String is Empty
            if (string.IsNullOrEmpty(CurrentToken))
            {
                return true;
            }

            var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadToken(CurrentToken) as System.IdentityModel.Tokens.Jwt.JwtSecurityToken;
            var expiryDate = jwtToken!.ValidTo;

            // Returns True if Expiry Time is less than 5 Minutes away
            return (expiryDate - DateTime.UtcNow).TotalMinutes < 5;
        }

        // Get the Current Claims Principal Authenticated User
        public async Task<ClaimsPrincipal> GetCurrentAuthenticatedUserClaimsPrincipal()
        {
            var authState = await AuthenticationState!;
            var User = authState.User;
            return User;
        }

        // Current User Token with Default Scopes
        public async Task<string> AcquireTokenAsync(string[] scopes, ClaimsPrincipal user)
        {
            try
            {
                var token = await _tokenAcquisition.GetAccessTokenForUserAsync(scopes, user: user);
                _userGroupService.SetCurentToken(token);

                return CurrentToken!;
            }
            catch (MsalUiRequiredException)
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
                var token = await _tokenAcquisition.GetAccessTokenForUserAsync(graphScopes);
                _userGroupService.SetCurentGraphToken(token);
                _userGroupService.SetUserUID(UserId);
                return CurrentGraphToken!;
            }
            catch (MsalUiRequiredException)
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

                var token = await _tokenAcquisition.GetAccessTokenForUserAsync(new[] { readWriteScope, readScope }!);
                _userGroupService.SetCurrentPowerBiToken(token);

                return CurrentPowerBiToken!;
            }
            catch (MsalUiRequiredException)
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
        }
        #endregion
    }
}
