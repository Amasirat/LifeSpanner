using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Core.Dtos.User;

public class CreateUserDto
{
    [MaxLength(50)]
    public required string Username { get; set; }
    
    [MaxLength(50), EmailAddress]
    public required string Email { get; set; }
    
    [MaxLength(64)]
    public required string Password { get; set; }
    
    [MaxLength(64), Compare("Password")]
    public required string PasswordConfirm { get; set; }
}