using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Domain.Entities;

public class User : BaseEntity
{
    [StringLength(50)]
    public required string Username { get; set; }
    
    [StringLength(50)]
    public required string Email { get; set; }
    
    [StringLength(256)]
    public required string PasswordHash { get; set; }
}