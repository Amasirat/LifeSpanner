using System.ComponentModel.DataAnnotations;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Domain.Entities;

public class Goal : BaseEntity
{
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public required User User { get; set; }
    
    public string? Description { get; set; }
    
    [EnumDataType(typeof(GoalStatusEnum))]
    public GoalStatusEnum Status { get; set; }
    
    public Goal? Parent { get; set; }
    
    public Project? Project { get; set; }
    
    public IEnumerable<Span> Spans { get; set; } = new List<Span>();
    
    public IEnumerable<Tactic> Tasks { get; set; } = new List<Tactic>();
}