using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Security.Claims;
using System.Text.Json;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication
{
    public sealed class CustomAuthenticationStateProvider : RevalidatingServerAuthenticationStateProvider, ICustomAuthenticationStateProvider
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly PersistentComponentState _state;
        private readonly IdentityOptions _options;
        private readonly PersistingComponentStateSubscription _subscription;
        private readonly IDistributedCache _cache;
        private Task<AuthenticationState>? _authenticationStateTask;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ClaimsPrincipal _currentUser;

        protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);

        public CustomAuthenticationStateProvider(
            PersistentComponentState persistentComponentState,
            ILoggerFactory loggerFactory,
            IServiceScopeFactory serviceScopeFactory,
            IOptions<IdentityOptions> optionsAccessor,
            IDistributedCache cache,
            IHttpContextAccessor httpContextAccessor)
            : base(loggerFactory)
        {
            _scopeFactory = serviceScopeFactory;
            _state = persistentComponentState;
            _options = optionsAccessor.Value;
            _cache = cache;
            _httpContextAccessor = httpContextAccessor;
            _currentUser = new ClaimsPrincipal(new ClaimsIdentity());

            AuthenticationStateChanged += OnAuthenticationStateChanged;
            _subscription = _state.RegisterOnPersisting(OnPersistingAsync, RenderMode.InteractiveWebAssembly);
        }

        private void OnAuthenticationStateChanged(Task<AuthenticationState> task)
        {
            _authenticationStateTask = task;
        }


        private async Task OnPersistingAsync()
        {
            if (_authenticationStateTask is null)
            {
                throw new UnreachableException($"Authentication state not set in {nameof(OnPersistingAsync)}().");
            }

            var authenticationState = await _authenticationStateTask;
            var principal = authenticationState.User;

            if (principal.Identity?.IsAuthenticated == true)
            {
                var userId = principal.FindFirst(_options.ClaimsIdentity.UserIdClaimType)?.Value;
                var name = principal.FindFirst(_options.ClaimsIdentity.UserNameClaimType)?.Value;
                var email = principal.FindFirst(_options.ClaimsIdentity.EmailClaimType)?.Value;
                var userRoles = principal.FindAll(_options.ClaimsIdentity.RoleClaimType);

                if (userRoles != null)
                {
                    var roles = userRoles.Select(r => r.Value).ToList();
                    _state.PersistAsJson(nameof(ApplicationUser), new ApplicationUser
                    {
                        UserId = userId,
                        UserName = name,
                        Email = email,
                        Roles = roles
                    });

                    // Update distributed cache
                    await _cache.SetStringAsync($"user_roles_{userId}",
                        JsonSerializer.Serialize(roles),
                        new DistributedCacheEntryOptions
                        {
                            AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1)
                        });
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            _subscription.Dispose();
            AuthenticationStateChanged -= OnAuthenticationStateChanged;
            base.Dispose(disposing);
        }

        protected override async Task<bool> ValidateAuthenticationStateAsync(AuthenticationState authenticationState, CancellationToken cancellationToken)
        {
            var user = authenticationState.User;
            if (user.Identity?.IsAuthenticated != true)
            {
                return false;
            }

            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return false;
            }

            var cachedRolesJson = await _cache.GetStringAsync($"user_roles_{userId}", cancellationToken);
            if (!string.IsNullOrEmpty(cachedRolesJson))
            {
                var cachedRoles = JsonSerializer.Deserialize<List<string>>(cachedRolesJson);
                var identity = new ClaimsIdentity(user.Claims.ToList(), user.Identity.AuthenticationType);

                foreach (var role in cachedRoles!)
                {
                    if (!identity.HasClaim(ClaimTypes.Role, role))
                    {
                        identity.AddClaim(new Claim(ClaimTypes.Role, role));
                    }
                }

                // Update the principal with new claims
                authenticationState = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            // Proceed with existing validation
            await using var scope = _scopeFactory.CreateAsyncScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            return await ValidateSecurityStampAsync(userManager, authenticationState.User);
        }

        private async Task<bool> ValidateSecurityStampAsync(UserManager<ApplicationUser> userManager, ClaimsPrincipal principal)
        {
            var user = await userManager.GetUserAsync(principal);
            if (user is null)
            {
                return false;
            }
            else if (!userManager.SupportsUserSecurityStamp)
            {
                return true;
            }
            else
            {
                var principalStamp = principal.FindFirstValue(_options.ClaimsIdentity.SecurityStampClaimType);
                var userStamp = await userManager.GetSecurityStampAsync(user);
                return principalStamp == userStamp;
            }
        }

        public async Task RefreshAuthenticationState()
        {
            var authenticationState = await GetAuthenticationStateAsync();
            NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));
        }
    }
}