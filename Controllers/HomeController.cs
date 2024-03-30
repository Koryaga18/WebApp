using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;

namespace Drones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRepository _repo;

        private readonly IHttpContextAccessor _httpContext;
        private readonly IStringLocalizer<HomeController> _local;

        public HomeController(ILogger<HomeController> logger, IRepository repo, IHttpContextAccessor httpContext, IStringLocalizer<HomeController> local)
        {
            _logger = logger;
            _repo = repo;
            _httpContext = httpContext;
            _local = local;
        }

        [Authorize]
        public IActionResult AboutUs()
        {



            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);

            string key = "IIN";
            string value = "021014550319";
            Response.Cookies.Append(key, value);
            Response.Cookies.Append("key_2", value);
            Response.Cookies.Append("key_3", value);



            return View();
        }
        [Authorize]
        public IActionResult Index(string culture, string cultureIU)
        {
            if (!string.IsNullOrEmpty(culture))
            {
                CultureInfo.CurrentCulture = new CultureInfo(culture);
                CultureInfo.CurrentUICulture = new CultureInfo(culture);
            }
            ViewBag.Index = _local["index"];
            GetCulture(culture);


            HttpContext.Session.SetString("ATR.IIN", "021014550319");

            string value = HttpContext.Session.GetString("product");


            _logger.LogInformation("testInfo");
            _logger.LogError("testInfo");

            string email = "dron@gmail.com";
            _logger.LogWarning("testInfo: {email} - {logTime}",
                email, DateTime.Now);
            
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Pages()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Blog()
        {
            return View();
        }
        
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;

            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password, string ReturnUrl)
        {

            if ((email == "admin@gmail.com") && (password == "admin"))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, email)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                Response.Cookies.Append("email", email);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                if (ReturnUrl=="")return Redirect(ReturnUrl);
                return Redirect("Index");
            }


            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
        public string GetCulture(string code = "")
        {
            if (!string.IsNullOrWhiteSpace(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);

                ViewBag.Culture = string.Format("CurrentCulture: {0}, CurrentUICulture: {1}", CultureInfo.CurrentCulture,
                    CultureInfo.CurrentUICulture);
            }
            return "";
        }
    }
}
