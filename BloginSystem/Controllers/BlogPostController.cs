using BloginSystem.Factories;
using BloginSystem.Models;
using BloginSystem.Repositories;
using BloginSystem.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IBlogPostFactory _blogPostFactory;

        public BlogPostController(IBlogPostService blogPostService,
            IBlogPostFactory blogPostFactory)
        {
            _blogPostService = blogPostService;
            _blogPostFactory = blogPostFactory;
        }
        
        public IActionResult AllBlogPosts()
        {
            var blogPosts = _blogPostService.GetAllBlogPost();

            var models = _blogPostFactory.PrepareBlogPostsList(blogPosts);

            return View(models);
        }
        [HttpGet]
        [Route("BlogPost/Details/{id}")]
        public IActionResult Details(int id)
        {
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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogPostModel blogPostModel)
        {
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
        [HttpGet]
        [Route("BlogPost/Delete/{id}")]
        public IActionResult Delete(int id)
        {
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(BlogPostModel blogPostModel)
        {
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

        [HttpGet]
        [Route("BlogPost/Update/{id}")]
        public IActionResult Update(int id)
        {
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(BlogPostModel blogPostModel)
        {
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
    }
}
