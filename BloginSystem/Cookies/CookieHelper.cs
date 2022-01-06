using Microsoft.AspNetCore.Http;
using System;

namespace BloginSystem.Cookies
{
    public class CookieHelper
	{
		public static void SetUserCookie(HttpContext httpContext,string cookie)
		{
			CookieOptions cookieOptions = new CookieOptions();
			cookieOptions.Expires = DateTime.Now.AddMinutes(1440);
			httpContext.Response.Cookies.Append("userCookie", cookie, cookieOptions);
			
		}
		public static string GetUserCookie(HttpContext httpContext)
		{
			var usercookie = httpContext.Request.Cookies["userCookie"];
			return usercookie;
		}
	}
}
