using HRCMS.Data;
using HRCMS.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using GoC.WebTemplate.Components.Core.Services;
using Microsoft.Extensions.Options;
using log4net;

namespace HRCMS.Controllers
{
    [AllowAnonymous]
    public class HomeController : ExtendedBaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly HrApi _portalSettings;


        public HomeController(IUserRepository userRepository, IOptions<HrApi> settings, ModelAccessor modelAccessor, ILog logger) : base(modelAccessor, logger)
        {
            _userRepository = userRepository;
            _portalSettings = settings.Value;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index(string id)
        {
            try
            {
                
                User user = await _userRepository.GetUserAsync(id);

                if (user != null)
                {
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                    identity.AddClaim(new Claim(ClaimTypes.PrimarySid, user.pri));
                    identity.AddClaim(new Claim(ClaimTypes.GivenName, user.firstName));
                    identity.AddClaim(new Claim(ClaimTypes.Surname, user.lastName));
                    identity.AddClaim(new Claim(ClaimTypes.Email, user.email));
                    identity.AddClaim(new Claim(ClaimTypes.Name, $"{user.firstName} {user.lastName}"));
                    identity.AddClaim(new Claim(ClaimTypes.StateOrProvince, $"{user.regionEng}::{user.regionFra}"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("List", "HRCase");
                }
                else
                {
                    _logger.Error($"Authentication Fail! - Token:{id}|{Request.Headers["User-Agent"]}");
                    return RedirectToAction("Error", "Home");
                }
            }
            catch
            {
                _logger.Error($"Authentication Fail! - Token:{id}|{Request.Headers["User-Agent"]}");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserModel aUser)
        {
            try
            {
                var user = await _userRepository.GetUserAsync(aUser.UserName);
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.PrimarySid, user.pri));
                identity.AddClaim(new Claim(ClaimTypes.GivenName, user.firstName));
                identity.AddClaim(new Claim(ClaimTypes.Surname, user.lastName));
                identity.AddClaim(new Claim(ClaimTypes.Email, user.email));
                identity.AddClaim(new Claim(ClaimTypes.Name, $"{user.firstName} {user.lastName}"));
                identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("List", "HRCase");
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Unable to authenticate. Please check your user name");
                return RedirectToAction("Index");
            }
        }
               
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Default()
        {
            WebTemplateModel.SplashPageInfo.EnglishHomeUrl = "/Home/index";
            WebTemplateModel.SplashPageInfo.FrenchHomeUrl = "/Home/index";
            WebTemplateModel.SplashPageInfo.EnglishTermsUrl = "http://www.canada.ca/en/transparency/terms.html";
            WebTemplateModel.SplashPageInfo.FrenchTermsUrl = "http://www.canada.ca/fr/transparence/avis.html";
            WebTemplateModel.SplashPageInfo.EnglishName = "Pay Case Management System";
            WebTemplateModel.SplashPageInfo.FrenchName = "Pay Case Management System (fr)";

            return View();
        }

    }
}
