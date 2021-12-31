using BloginSystem.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.Validators
{
    public class BlogPostValidator: AbstractValidator<BlogPost>
    {
        public BlogPostValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();
            RuleFor(x => x.Title)
                .NotNull();
            RuleFor(x => x.Authorname)
                .NotNull();
            RuleFor(x => x.CreatedAt)
                .NotNull();
            RuleFor(x => x.BlogBody)
                .NotNull();
        }
    }
}
