using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Data;
using System.Diagnostics;
using System.Security.Claims;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication
{
    // Authentication State Provider to keep Application up to date on Authentication State Changes
    public sealed class CustomAuthenticationStateProvider : RevalidatingServerAuthenticationStateProvider, ICustomAuthenticationStateProvider
    {
        #region Private Fields

        private readonly IServiceScopeFactory _scopeFactory;
        private readonly PersistentComponentState _state;
        private readonly IdentityOptions _options;
        private readonly PersistingComponentStateSubscription _subscription;
        private Task<AuthenticationState>? _authenticationStateTask;
        protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);
        private ClaimsPrincipal _currentUser;

        #endregion

        #region Constructor

        public CustomAuthenticationStateProvider(
            PersistentComponentState persistentComponentState,
            ILoggerFactory loggerFactory,
            IServiceScopeFactory serviceScopeFactory,
            IOptions<IdentityOptions> optionsAccessor)
            : base(loggerFactory)
        {
            _scopeFactory = serviceScopeFactory;
            _state = persistentComponentState;
            _options = optionsAccessor.Value;
            _currentUser = new ClaimsPrincipal(new ClaimsIdentity());

            AuthenticationStateChanged += OnAuthenticationStateChanged;
            _subscription = _state.RegisterOnPersisting(OnPersistingAsync, RenderMode.InteractiveWebAssembly);
        }

        #endregion

        #region Event Handlers

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
                    _state.PersistAsJson(nameof(ApplicationUser), new ApplicationUser
                    {
                        UserId = userId,
                        UserName = name,
                        Email = email,
                        Roles = userRoles.Select(r => r.Value).ToList()
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

        #endregion
    }
}