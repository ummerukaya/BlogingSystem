using BloginSystem.Models;
using BloginSystem.DataAccess;
using System.Collections.Generic;

namespace BloginSystem.Factories
{
    public class BlogPostFactory : IBlogPostFactory
    {
        public BlogPost PrepareBlogPost(BlogPostModel blogPostModel)
        {
            var entity = new BlogPost();
            entity.Id = blogPostModel.Id;
            entity.Title = blogPostModel.Title;
            entity.Authorname = blogPostModel.Authorname;
            entity.CreatedAt = blogPostModel.CreatedAt;
            entity.BlogBody = blogPostModel.BlogBody;
            return entity;
        }

        public BlogPost PrepareExistingBlogPost(BlogPostModel blogPostModel,BlogPost entity)
        {
            entity.Title = blogPostModel.Title;
            entity.Authorname = blogPostModel.Authorname;
            entity.CreatedAt = blogPostModel.CreatedAt;
            entity.BlogBody = blogPostModel.BlogBody;
            return entity;
        }

        public BlogPostModel PrepareBlogPostModel(BlogPost blogPost)
        {
            var model = new BlogPostModel();
            model.Id = blogPost.Id;
            model.Title = blogPost.Title;
            model.Authorname = blogPost.Authorname;
            model.CreatedAt = blogPost.CreatedAt;
            model.BlogBody = blogPost.BlogBody;
            return model;
        }

        public List<BlogPostModel> PrepareBlogPostsList(List<BlogPost> blogPosts)
        {
            var models = new List<BlogPostModel>();
            for (var i = 0; i < blogPosts.Count; i++)
            {
                models.Add(new BlogPostModel()
                {
                    Id = blogPosts[i].Id,
                    Title = blogPosts[i].Title,
                    Authorname = blogPosts[i].Authorname,
                    CreatedAt = blogPosts[i].CreatedAt,
                    BlogBody = blogPosts[i].BlogBody
                });
            }
            return models;
        }

    }
}
