

using AuthService.Application.DTOs.Requests;
using AuthService.Application.Interfaces;

namespace AuthService.Application.Services;

public class AuthService : IAuthService
{
    Task<string> IAuthService.LoginAsync(LoginRequest request)
    {
        throw new NotImplementedException();
    }

    Task<string> IAuthService.RegisterAsync(RegisterRequest request)
    {
        throw new NotImplementedException();
    }
}
