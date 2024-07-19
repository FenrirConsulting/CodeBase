using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Caching.Distributed;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication
{
    public class CustomClaimsTransform : IClaimsTransformation
    {
        private readonly ILogHelper _logHelper;
        private readonly IDistributedCache _cache;
        private readonly IAppConfiguration _appConfiguration;

        public CustomClaimsTransform(ILogHelper logHelper, IDistributedCache cache, IAppConfiguration appConfiguration)
        {
            _logHelper = logHelper;
            _cache = cache;
            _appConfiguration = appConfiguration;
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (!principal.Identity?.IsAuthenticated ?? true)
            {
                return principal;
            }

            string username = principal.Identity!.Name!;

            try
            {
                var cachedRoles = await GetCachedRolesAsync(username);
                var currentRoles = principal.FindAll(ClaimTypes.Role).Select(c => c.Value).ToHashSet();

                var allRoles = currentRoles.Union(cachedRoles).ToHashSet();

                var newIdentity = new ClaimsIdentity(principal.Identity);
                UpdateRoleClaims(newIdentity, allRoles);

                return new ClaimsPrincipal(newIdentity);
            }
            catch (Exception ex)
            {
                _logHelper.LogError($"Error transforming claims for user {username}: {ex.Message}", ex);
                return principal;
            }
        }

        private async Task<HashSet<string>> GetCachedRolesAsync(string username)
        {
            byte[]? cachedRolesBytes = await _cache.GetAsync($"user_roles_{username}");
            if (cachedRolesBytes != null)
            {
                string serializedRoles = Encoding.UTF8.GetString(cachedRolesBytes);
                return JsonSerializer.Deserialize<HashSet<string>>(serializedRoles) ?? new HashSet<string>();
            }
            return new HashSet<string>();
        }

        private void UpdateRoleClaims(ClaimsIdentity identity, HashSet<string> roles)
        {
            var existingRoleClaims = identity.FindAll(ClaimTypes.Role).ToList();
            foreach (var claim in existingRoleClaims)
            {
                identity.RemoveClaim(claim);
            }

            foreach (var role in roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
            }
        }
    }
}