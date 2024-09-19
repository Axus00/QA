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
            Include(new UserNamesRule());
            Include(new UserLastNamesRule());
            Include(new UserEmailRule());
        }

        //validations
        public class UserNamesRule : AbstractValidator<User>
        {
            public UserNamesRule()
            {
                RuleFor(user => user.Names).NotEmpty()
                                              .WithMessage("The field FullName is required");
            }
        }

        public class UserLastNamesRule : AbstractValidator<User>
        {
            public UserLastNamesRule()
            {
                RuleFor(user => user.LastNames).NotEmpty()
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