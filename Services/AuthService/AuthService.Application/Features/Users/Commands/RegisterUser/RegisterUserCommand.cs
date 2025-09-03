using AuthService.Application.DTOs.Responses;
using AuthService.Application.Features.Users.DTOs;
using MediatR;



namespace AuthService.Application.Features.Users.Commands.RegisterUser;


public class RegisterUserCommand : IRequest<UserDto>
{
    public string FullName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}



