using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeSpanner.Domain.Entities;

public class Span : BaseEntity
{
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public required User User { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly StartDate { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly EndDate { get; set; }
    
    public required uint WeekCount { get; set; }
    
    public required IEnumerable<Goal> Goals { get; set; } = new List<Goal>();
    
    public required IEnumerable<Week> Weeks { get; set; } = new List<Week>();
}