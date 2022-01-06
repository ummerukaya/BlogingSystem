using BloginSystem.DataAccess;
using FluentValidation;

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
