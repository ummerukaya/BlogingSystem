using BloginSystem.Cookies;
using BloginSystem.Entities;
using BloginSystem.Factories;
using BloginSystem.Models;
using BloginSystem.Services;
using BloginSystem.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloginSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserFactory _userFactory;
        public UserController(IUserService userService,
            IUserFactory userFactory)
        {
            _userService = userService;
            _userFactory = userFactory;
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(UserModel userModel)
        {
            try
            {
                var user = _userFactory.PrepareUser(userModel);
                _userService.InsertUser(user);

                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }


        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoggedinUserModel model)
        {
            var loggedinUser = _userService.Validate(model);
            //validate 
            if (loggedinUser!=null)
            {
                string str = loggedinUser.Email.ToString() + ":" + loggedinUser.Password.ToString();
                str = Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
                CookieHelper.SetUserCookie(HttpContext, str);
                return RedirectToAction("Index","User");
            }
            else 
            {
                return View();
            }

        }
        [Route("User/Index")]
        public IActionResult Index()
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var str = Encoding.UTF8.GetString(Convert.FromBase64String(cookieVal));

                var userData = str.Split(":");
                var userModel = new LoggedinUserModel()
                {
                        Email = userData[0],
                        Password = userData[1]
                };
                var loggedinUser = _userService.Validate(userModel);

                return View();

            }
            catch
            {
                throw new Exception("invalid user");
            }
            
        }

    }
}
