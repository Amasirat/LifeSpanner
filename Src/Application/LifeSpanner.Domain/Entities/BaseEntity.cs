using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeSpanner.Domain.Entities;

public abstract class BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public Guid Id { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    
    public bool IsDeleted { get; set; }
}