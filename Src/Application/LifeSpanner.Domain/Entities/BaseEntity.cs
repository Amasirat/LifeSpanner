using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeSpanner.Domain.Entities;

public abstract class BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public Guid Id { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public bool IsDeleted { get; set; }
}