using BloginSystem.DataAccess;
using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace BloginSystem.Validators
{
    public class UserValidator: AbstractValidator<User>
    {
		public UserValidator()
		{
			RuleFor(x => x.Id)
				.NotNull();
			RuleFor(x => x.Firstname)
				.Length(0, 10)
				.NotNull();
			RuleFor(x => x.Lastname)
				.Length(0, 10)
				.NotNull();
			RuleFor(x => x.Email)
				.EmailAddress()
				.NotNull();
			RuleFor(x => x.DOB)
				.InclusiveBetween(
					new DateTime(1900, 1, 1), DateTime.Now.AddYears(-10));
			RuleFor(x => x.PhoneNumber).Length(11);
			
			RuleFor(x => x.Password)
				.NotNull()
				.Length(8,16)
				.Must(x =>
					!string.IsNullOrEmpty(x) && Regex.IsMatch(x, @"^\d$"))
				.WithMessage("Invalid Password");
		}
	}
}
