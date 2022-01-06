using BloginSystem.Cookies;
using BloginSystem.Factories;
using BloginSystem.Models;
using BloginSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

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
            var loggedinUser = _userService.Validate(model.Email,model.Password);
            //validate 
            if (loggedinUser!=null)
            {
                string str = loggedinUser.Email.ToString() + ":" + loggedinUser.Password.ToString();
                str = Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
                CookieHelper.SetUserCookie(HttpContext, str);
                return RedirectToAction("Index","Home");
            }
            else 
            {
                return View();
            }

        }
       

    }
}
