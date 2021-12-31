using BloginSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.DataSource
{
    public class BlogPostData : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasData(
                new BlogPost
                {
                    Id = 1,
                    Title = "Blog post title",
                    Authorname="Suny",
                    CreatedAt = DateTime.Now,
                    BlogBody="abcdefg"
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "Blog post title",
                    Authorname = "Suny",
                    CreatedAt = DateTime.Now,
                    BlogBody = "abcdefg"
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Blog post title",
                    Authorname = "Suny",
                    CreatedAt = DateTime.Now,
                    BlogBody = "abcdefg"
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "Blog post title",
                    Authorname = "Suny",
                    CreatedAt = DateTime.Now,
                    BlogBody = "abcdefg"
                },
                new BlogPost
                {
                    Id = 5,
                    Title = "Blog post title",
                    Authorname = "Suny",
                    CreatedAt = DateTime.Now,
                    BlogBody = "abcdefg"
                }
            );
        }
    }
}
