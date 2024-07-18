using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Web;

namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell.Controllers
{
    [ApiController]
    [Route("/Account")]
    public class AuthenticationController(IAppConfiguration appConfiguration, ILogHelper logger, HttpClient httpClient) : Controller
    {
        private readonly IAppConfiguration _appConfiguration = appConfiguration;
        private readonly ILogHelper _logger = logger;
        private readonly HttpClient _httpClient = httpClient;


        [AllowAnonymous]
        [HttpGet("cookieLogin")]
        public IActionResult Login(string returnUrl = "/")
        {
            returnUrl = _appConfiguration.ReturnURL;

            var authenticationUrl = $"{_appConfiguration.AuthenticationAPIURL}login";
            var callbackUrl = $"{returnUrl}Account/callback";

            return Redirect($"{authenticationUrl}?returnUrl={HttpUtility.UrlEncode(callbackUrl)}");
        }

        [AllowAnonymous]
        [HttpGet("callback")]
        public IActionResult Callback(string returnUrl = "/")
        {
            returnUrl = _appConfiguration.ReturnURL;
            return Redirect(returnUrl);
        }

        [Authorize]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [Route("accessdenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
