﻿

namespace AuthService.Domain.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Role { get; set; } = "Customer";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
