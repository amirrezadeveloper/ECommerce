using AuthService.Domain.Entities;
using FluentValidation;

namespace AuthService.Application.Features.Users.Commands.RegisterUser;

public class RegisterUserHandler: AbstractValidator<User>
{
    public RegisterUserValidator()
    {

        RuleFor(x => x.Email)
            .EmailAddress();

        RuleFor(x => x.Password).MinimumLength(8);  

    }
}
