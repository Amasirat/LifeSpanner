using LifeSpanner.Common.Types;

namespace LifeSpanner.Core.Dtos.User;

public class UserDto
{
    public Guid Id { get; set; }
    
    public required string Username { get; set; }
    
    public required string Email { get; set; }
    
    public UserRoleEnum Role { get; set; }
    
    public DateTime EmailVerifiedAt { get; set; }
    
    public ushort EndDayOffset { get; set; }
}