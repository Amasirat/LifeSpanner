using System.ComponentModel.DataAnnotations;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Domain.Entities;

public class User : BaseEntity
{
    [MaxLength(50)]
    public required string Username { get; set; }
    
    [MaxLength(50)]
    public required string Email { get; set; }
    
    [MaxLength(256)]
    public required string PasswordHash { get; set; }
    
    [EnumDataType(typeof(UserRoleEnum))]
    public UserRoleEnum Role { get; set; }
    
    public DateTime? EmailVerifiedAt { get; set; }
    
    public ushort EndDayOffset { get; set; }
}