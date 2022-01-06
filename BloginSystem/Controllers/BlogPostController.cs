using BloginSystem.Cookies;
using BloginSystem.Factories;
using BloginSystem.Models;
using BloginSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BloginSystem.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IBlogPostFactory _blogPostFactory;
        private readonly IUserService _userService;
       

        public BlogPostController(IBlogPostService blogPostService,
            IBlogPostFactory blogPostFactory,IUserService userService)
        {
            _blogPostService = blogPostService;
            _blogPostFactory = blogPostFactory;
            _userService = userService;
        }
        
        public IActionResult AllBlogPosts()
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email,userModel.Password);
                var blogPosts = _blogPostService.GetAllBlogPost();
                var models = _blogPostFactory.PrepareBlogPostsList(blogPosts);
                return View(models);
            }
            catch
            {
                throw new Exception("invalid user");
            }
            
        }
        [HttpGet]
        [Route("BlogPost/Details/{id}")]
        public IActionResult Details(int id)
        {
           
                try
                {
                    var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                    var userModel = CookieValidation.CookieValidate(cookieVal);
                    var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                    var blogPost = _blogPostService.GetBlogPostById(id);
                    if (blogPost == null)
                    {
                        return RedirectToAction("AllBlogPosts");
                    }
                    else
                    {
                        var model = _blogPostFactory.PrepareBlogPostModel(blogPost);
                        return View(model);
                    }
                }
                catch
                {
                    throw new Exception("invalid user");
                }
            
        }
        [HttpGet]
        public IActionResult Create()
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogPostModel blogPostModel)
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                try
                {
                    var blogPost = _blogPostFactory.PrepareBlogPost(blogPostModel);
                    _blogPostService.InsertBlogPost(blogPost);
                    return RedirectToAction("AllBlogPosts");
                }
                catch
                {
                    return View();
                }
            }
            catch
            {
                throw new Exception("invalid user");
            }
             
        }

        [HttpGet]
        [Route("BlogPost/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                var blogPost = _blogPostService.GetBlogPostById(id);
                if (blogPost == null)
                {
                    return RedirectToAction("AllBlogPosts");
                }
                else
                {
                    var model = _blogPostFactory.PrepareBlogPostModel(blogPost);
                    return View(model);
                }
            }
            catch
            {
                throw new Exception("invalid user");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(BlogPostModel blogPostModel)
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                try
                {
                    var blogPost = _blogPostFactory.PrepareBlogPost(blogPostModel);
                    var b = _blogPostService.GetBlogPostById(blogPost.Id);
                    if (b != null)
                    {
                        _blogPostService.DeleteBlogPost(b);
                    }

                    return RedirectToAction("AllBlogPosts");
                }
                catch
                {
                    return View();
                }
            }
            catch
            {
                throw new Exception("invalid user");
            }
        }

        [HttpGet]
        [Route("BlogPost/Update/{id}")]
        public IActionResult Update(int id)
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                var blogPost = _blogPostService.GetBlogPostById(id);
                if (blogPost == null)
                {
                    return RedirectToAction("AllBlogPosts");
                }
                else
                {
                    var model = _blogPostFactory.PrepareBlogPostModel(blogPost);
                    return View(model);
                }
            }
            catch
            {
                throw new Exception("invalid user");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(BlogPostModel blogPostModel)
        {
            try
            {
                var cookieVal = CookieHelper.GetUserCookie(HttpContext);
                var userModel = CookieValidation.CookieValidate(cookieVal);
                var loggedinUser = _userService.Validate(userModel.Email, userModel.Password);
                try
                {
                    var blogPost = _blogPostService.GetBlogPostById(blogPostModel.Id);
                    if (blogPost != null)
                    {
                        blogPost = _blogPostFactory.PrepareExistingBlogPost(blogPostModel, blogPost);
                        _blogPostService.UpdateBlogPost(blogPost);
                    }
                    return RedirectToAction("AllBlogPosts");
                }
                catch
                {
                    return View();
                }
            }
            catch
            {
                throw new Exception("invalid user");
            }
        }
    }
}
