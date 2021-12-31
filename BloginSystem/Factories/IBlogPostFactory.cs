using BloginSystem.Entities;
using BloginSystem.Models;
using System.Collections.Generic;

namespace BloginSystem.Factories
{
    public interface IBlogPostFactory
    {
        BlogPost PrepareBlogPost(BlogPostModel blogPostModel);
        BlogPost PrepareExistingBlogPost(BlogPostModel blogPostModel,BlogPost entity);
        BlogPostModel PrepareBlogPostModel(BlogPost blogPost);
        List<BlogPostModel> PrepareBlogPostsList(List<BlogPost> blogPosts);
    }
}