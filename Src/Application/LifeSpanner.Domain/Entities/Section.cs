using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Domain.Entities;

public class Section : BaseEntity
{
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public required Project Project { get; set; }
    
    public IEnumerable<Tactic> Tasks { get; set; } = new List<Tactic>();
}