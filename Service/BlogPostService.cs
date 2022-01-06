using BloginSystem.DataAccess;
using BloginSystem.Repository;
using System.Collections.Generic;

namespace BloginSystem.Service
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IRepository<BlogPost> _repository;

        public BlogPostService(IRepository<BlogPost> repository)
        {
            _repository = repository;
        }
        public void DeleteBlogPost(BlogPost blogPost)
        {
            _repository.Delete(blogPost);
        }
        public List<BlogPost> GetAllBlogPost()
        {
            return _repository.GetAll();
        }
        public BlogPost GetBlogPostById(int id)
        {
            return _repository.GetById(id);
        }
        public void InsertBlogPost(BlogPost blogPost)
        {
            _repository.Insert(blogPost);
        }
        public void UpdateBlogPost(BlogPost blogPost)
        {
            _repository.Update(blogPost);
        }

    }
}
