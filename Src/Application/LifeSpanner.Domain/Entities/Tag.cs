using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Domain.Entities;

public class Tag : BaseEntity
{
    public required User User { get; set; }
    
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public IEnumerable<TimeBlock> TimeBlocks { get; set; } = new List<TimeBlock>();
}