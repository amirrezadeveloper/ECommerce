using AuthService.Application.DTOs.Responses;
using MediatR;



namespace AuthService.Application.Features.Users.Commands.RegisterUser;


public record RegisterUserCommand(string Username, string Email, string Password) : IRequest<AuthResponse>;



