using BloginSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloginSystem.Cookies
{
    public class CookieValidation
    {
        public static LoggedinUserModel CookieValidate(string cookieVal)
        {
            try
            {
                var str = Encoding.UTF8.GetString(Convert.FromBase64String(cookieVal));
                var userData = str.Split(":");
                var userModel = new LoggedinUserModel()
                {
                    Email = userData[0],
                    Password = userData[1]
                };

                return userModel;
            }
            catch
            {
                throw new Exception("invalid user");
            }
        }
    }
}
