using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Domain.Entities;

public class Project : BaseEntity
{
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public DateTime Deadline { get; set; }
    
    public required User User { get; set; }
    
    public Project? Parent { get; set; }
    
    public IEnumerable<Goal> Goals { get; set; } = new List<Goal>();
    public IEnumerable<Tactic> Tasks { get; set; } = new List<Tactic>();
    public IEnumerable<Section> Sections { get; set; } = new List<Section>();
}