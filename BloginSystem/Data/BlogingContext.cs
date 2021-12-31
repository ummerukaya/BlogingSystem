using BloginSystem.DataSource;
using BloginSystem.Entities;
using Microsoft.EntityFrameworkCore;
using BloginSystem.Models;

namespace BloginSystem.Data
{
    public class BlogingContext:DbContext
    {
        public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<User> users { get; set; }
        public BlogingContext(DbContextOptions<BlogingContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BlogPostData());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=BS-687\SQLEXPRESS;Database=BlogingDB;Trusted_Connection=True;");
            }
        }
        //public DbSet<BloginSystem.Models.BlogPostModel> BlogPostModel { get; set; }
        //public DbSet<BloginSystem.Models.UserModel> UserModel { get; set; }
    }
}
