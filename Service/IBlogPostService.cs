
using BloginSystem.DataAccess;
using System.Collections.Generic;

namespace BloginSystem.Service
{
    public interface IBlogPostService
    {
        void DeleteBlogPost(BlogPost blogPost);
        List<BlogPost> GetAllBlogPost();
        BlogPost GetBlogPostById(int id);
        void InsertBlogPost(BlogPost blogPost);
        void UpdateBlogPost(BlogPost blogPost);
    }
}