using BloginSystem.Cookies;
using BloginSystem.Models;
using BloginSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace BloginSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger,IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                return View();
            }
            catch
            {
                throw new Exception("invalid user");
            }
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
