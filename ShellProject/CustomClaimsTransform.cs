using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

public class CustomClaimsTransform : IClaimsTransformation
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IDomainUserGroupService _domainUserGroupService;
    private readonly ILogger<CustomClaimsTransform> _logger;
    private readonly LdapRoleMappingConfig _ldapRoleMappingConfig;
    private readonly ILogHelper _LogHelper;

    public CustomClaimsTransform(IDomainUserGroupService domainUserGroupService, IHttpContextAccessor httpContextAccessor,
        ILogger<CustomClaimsTransform> logger, LdapRoleMappingConfig ldapRoleMappingConfig, ILogHelper LogHelper)
    {
        _httpContextAccessor = httpContextAccessor;
        _domainUserGroupService = domainUserGroupService;
        _logger = logger;
        _ldapRoleMappingConfig = ldapRoleMappingConfig;
        _LogHelper = LogHelper;
    }

    public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        try
        {
            if (principal.Identity!.IsAuthenticated)
            {
                string username = principal.Identity.Name!;

                // Get roles from the cache
                List<string> cachedRoles = UserGroupsCache.GetUserRoles(username);

                // If cache is empty, populate it from existing claims
                if (!cachedRoles.Any())
                {
                    var existingRoles = principal.Claims
                        .Where(claim => claim.Type == ClaimTypes.Role)
                        .Select(claim => claim.Value)
                        .ToList();

                    UserGroupsCache.AddUserRoles(username, existingRoles);
                    cachedRoles = UserGroupsCache.GetUserRoles(username);
                }

                // Get additional roles from the AdditionalRoles claim
                var additionalRolesClaim = principal.FindFirst("AdditionalRoles");
                if (additionalRolesClaim != null)
                {
                    var additionalRoles = additionalRolesClaim.Value.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
                    cachedRoles.AddRange(additionalRoles);
                    cachedRoles = cachedRoles.Distinct().ToList();

                    UserGroupsCache.AddUserRoles(username, additionalRoles);
                }

                // Create a new identity with all roles
                var newIdentity = new ClaimsIdentity(principal.Identity);

                // Remove existing role claims
                var existingRoleClaims = newIdentity.Claims.Where(c => c.Type == ClaimTypes.Role).ToList();
                foreach (var claim in existingRoleClaims)
                {
                    newIdentity.RemoveClaim(claim);
                }

                // Add all roles as claims
                foreach (var role in cachedRoles)
                {
                    newIdentity.AddClaim(new Claim(ClaimTypes.Role, role));
                }

                // Create a new principal with the updated identity
                var newPrincipal = new ClaimsPrincipal(newIdentity);

                return Task.FromResult(newPrincipal);
            }
        }
        catch (Exception ex)
        {
            _LogHelper.LogError(ex.Message, ex);
        }

        return Task.FromResult(principal);
    }
}