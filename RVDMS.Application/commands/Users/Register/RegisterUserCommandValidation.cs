using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.Register
{
    public class RegisterUserCommandValidation : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidation()
        {
            RuleFor(x => x.UserName)
               .NotEmpty().WithMessage("Username is required")
               .MinimumLength(3).WithMessage("Username must be at least 3 characters");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email address");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required");

            RuleFor(x => x.BaseLatitude)
                .InclusiveBetween(-90, 90)
                .WithMessage("Base latitude must be between -90 and 90");

            RuleFor(x => x.BaseLongitude)
                .InclusiveBetween(-180, 180)
                .WithMessage("Base longitude must be between -180 and 180");

            RuleFor(x => x.BaseRadiusInMeters)
                .GreaterThan(0)
                .WithMessage("Base radius must be greater than 0 meters");
        }
    }
}
