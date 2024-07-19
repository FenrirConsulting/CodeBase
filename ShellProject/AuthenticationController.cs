using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text;

namespace CVSHealth.IAM.IAPF.Tools.AuthenticateAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/")]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserPreferencesService? _userPreferencesService;
        private readonly IDomainUserGroupService _domainUserGroupService;
        private readonly LdapRoleMappingConfig _ldapRoleMappingConfig;
        private readonly IWebHostEnvironment _env;
        private readonly ILogHelper _logger;
        private readonly IAppConfiguration _appConfiguration;
        private readonly IUserSettingsRepository _userSettingsRepository;
        private readonly IDistributedCache _cache;

        public AuthenticationController(IUserPreferencesService userPreferencesService, IHttpContextAccessor httpContextAccessor,
               IDomainUserGroupService domainUserGroupService, LdapRoleMappingConfig ldapRoleMappingConfig, IWebHostEnvironment env,
               ILogHelper logger, IAppConfiguration appConfiguration, IUserSettingsRepository userSettingsRepository, IDistributedCache cache)
        {
            _httpContextAccessor = httpContextAccessor;
            _userPreferencesService = userPreferencesService;
            _domainUserGroupService = domainUserGroupService;
            _ldapRoleMappingConfig = ldapRoleMappingConfig;
            _env = env;
            _logger = logger;
            _appConfiguration = appConfiguration;
            _userSettingsRepository = userSettingsRepository;
            _cache = cache;
        }

        // LoginUser with Sign In of Claims based on Role Membership
        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> Login(string returnUrl)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var username = User.Identity.Name;
                var lastAuthenticated = DateTime.UtcNow;
                var roles = _domainUserGroupService.GetRolesFromGroups(User);

                // Create claims with the Claim Name from Identity Name as well as adding roles and Last Authenticated Timestamp
                var claims = _domainUserGroupService.CreateClaims(User.Identity.Name!, roles, lastAuthenticated);

                // Add roles to cache
                string serializedRoles = JsonSerializer.Serialize(roles);
                await _cache.SetAsync(
                    $"user_roles_{username}",
                    Encoding.UTF8.GetBytes(serializedRoles),
                    new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_appConfiguration.CookieTimeout),
                        SlidingExpiration = TimeSpan.FromMinutes(30)
                    });

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var authenticationProperties = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = lastAuthenticated.AddHours(_appConfiguration.CookieTimeout)
                };

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);

                _logger.LogMessage("Login User Identity Name : " + username);
                return Redirect(returnUrl);
            }
            else
            {
                return Unauthorized();
            }
        }

        [AllowAnonymous]
        [HttpGet("cookieLogin")]
        public async Task<IActionResult> CookieLogin()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var username = User.Identity.Name;
                var lastAuthenticated = DateTime.UtcNow;
                var roles = _domainUserGroupService.GetRolesFromGroups(User);

                // Create claims with the Claim Name from Identity Name as well as adding roles and Last Authenticated Timestamp
                var claims = _domainUserGroupService.CreateClaims(User.Identity.Name!, roles, lastAuthenticated);

                // Add roles to cache
                string serializedRoles = JsonSerializer.Serialize(roles);
                await _cache.SetAsync(
                    $"user_roles_{username}",
                    Encoding.UTF8.GetBytes(serializedRoles),
                    new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_appConfiguration.CookieTimeout),
                        SlidingExpiration = TimeSpan.FromMinutes(30)
                    });

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var authenticationProperties = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = lastAuthenticated.AddHours(_appConfiguration.CookieTimeout)
                };

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);

                _logger.LogMessage("Login User Identity Name : " + username);

                return Redirect(_appConfiguration.AuthenticationAPIURL);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity!.IsAuthenticated == true)
            {
                var username = User.Identity.Name;
                await _cache.RemoveAsync($"user_roles_{username}");
            }

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(new { Message = "Logged Out" });
        }

        // Update Current Users Roles based on Passed In Roles
        [HttpPost("updateRoles")]
        public async Task<IActionResult> UpdateRoles([FromBody] RoleUpdateRequest request)
        {
            if (request.Roles == null)
            {
                return BadRequest("Roles cannot be null");
            }

            try
            {
                var identity = (ClaimsIdentity)User.Identity!;
                var username = identity.Name!;

                // Get existing roles
                var existingRoles = identity.FindAll(ClaimTypes.Role).Select(c => c.Value).ToHashSet();

                // Add new roles
                foreach (var role in request.Roles)
                {
                    existingRoles.Add(role);
                }

                // Create new identity with updated role claims
                var newClaims = identity.Claims
                    .Where(c => c.Type != ClaimTypes.Role)
                    .Concat(existingRoles.Select(r => new Claim(ClaimTypes.Role, r)))
                    .ToList();

                var newIdentity = new ClaimsIdentity(newClaims, identity.AuthenticationType);
                var newPrincipal = new ClaimsPrincipal(newIdentity);

                // Sign in with the new principal
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    newPrincipal,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.UtcNow.AddHours(_appConfiguration.CookieTimeout)
                    });

                // Update the cache
                await _cache.SetStringAsync(
                    $"user_roles_{username}",
                    JsonSerializer.Serialize(existingRoles.ToList()),
                    new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_appConfiguration.CookieTimeout)
                    });

                return Ok(new
                {
                    Message = "Roles updated successfully",
                    Roles = existingRoles.ToList()
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Role Update Error", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating roles.");
            }
        }

        [HttpGet("claims")]
        public async Task<IActionResult> GetClaims()
        {
            if (User.Identity!.IsAuthenticated)
            {
                var userId = User.Identity!.Name;

                // Get roles from cache
                byte[]? cachedRolesBytes = await _cache.GetAsync($"user_roles_{userId}");
                List<string> cachedRoles = new List<String>();

                if (cachedRolesBytes != null)
                {
                    string serializedRoles = Encoding.UTF8.GetString(cachedRolesBytes);
                    cachedRoles = JsonSerializer.Deserialize<List<string>>(serializedRoles)!;
                }

                var claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList();

                // Add cached roles to claims if not already present
                foreach (var role in cachedRoles)
                {
                    if (!claims.Any(c => c.Type == ClaimTypes.Role && c.Value == role))
                    {
                        claims.Add(new { Type = ClaimTypes.Role, Value = role});
                    }
                }

                return Ok(claims);
            }

            return Unauthorized();
        }

        // Validation of Authenticated or Not
        [HttpGet("validate")]
        public async Task<IActionResult> Validate()
        {
            if (User.Identity!.IsAuthenticated)
            {
                var userId = User.Identity.Name;

                // Get roles from cache
                byte[]? cachedRolesBytes = await _cache.GetAsync($"user_roles_{userId}");
                List<string> cachedRoles = new List<String>();

                if (cachedRolesBytes != null)
                {
                    string serializedRoles = Encoding.UTF8.GetString(cachedRolesBytes);
                    cachedRoles = JsonSerializer.Deserialize<List<string>>(serializedRoles)!;
                }

                return Ok(new
                {
                    IsAuthenticated = true,
                    Username = userId,
                    Roles = cachedRoles
                });
            }

            return Unauthorized();
        }

        [HttpGet("userId")]
        public async Task<IActionResult> GetUserSettings(string userId)
        {
            var userSettings = await _userSettingsRepository.GetUserSAMAsync(userId);
            if (userSettings == null)
            {
                return NotFound("Not Found");
            }

            return Ok(userSettings);
        }
    }
}