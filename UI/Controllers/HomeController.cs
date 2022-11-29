using Business;
using Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;
using System.Security.Claims;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly DataContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public HomeController(DataContext context)
        {
            _ctx = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(new Authentication());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Index(Authentication model)
        {
            var serviceAuth = new ServiceAuthentication(_ctx);

            switch (await serviceAuth.AuthenticateAsync(model))
            {
                case AuthenticationResult.Success:
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Email),
                        new Claim(ClaimTypes.PrimarySid, model.Id.ToString()),
                        new Claim(ClaimTypes.Email, model.Email),
                        // RIGHTS
                        new Claim(ClaimTypes.Role, "read")
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authenticationProperties = new AuthenticationProperties { IsPersistent = true };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authenticationProperties);

                    TempData["message"] = "Bienvenue error !";
                    return RedirectToAction("Index", "Home");
                case AuthenticationResult.Error:
                    TempData["message"] = "Authentication error !";
                    return View(model);
                case AuthenticationResult.NotFound:
                    TempData["message"] = "Account not found !";
                    return View(model);
                case AuthenticationResult.AccountError:
                    TempData["message"] = "Account disabled !";
                    return View(model);
                default:
                    TempData["message"] = "Authentication unknowed error !";
                    return View(model);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}