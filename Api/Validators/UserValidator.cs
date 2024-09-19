using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using FluentValidation;

namespace Api.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            Include(new UserFullNameRule());
            Include(new UserEmailRule());
        }

        //validations
        public class UserFullNameRule : AbstractValidator<User>
        {
            public UserFullNameRule()
            {
                RuleFor(user => user.FullName).NotEmpty()
                                              .WithMessage("The field FullName is required");
            }
        }

        public class UserEmailRule : AbstractValidator<User>
        {
            public UserEmailRule()
            {
                RuleFor(user => user.Email).NotEmpty()
                                           .WithMessage("The Email is required")
                                           .EmailAddress()
                                           .WithMessage("The Email has isn`t in the correct format"); 
            }
        }
    }
}