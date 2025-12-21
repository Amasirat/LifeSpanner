using System.ComponentModel.DataAnnotations.Schema;

namespace LifeSpanner.Domain.Entities;

public class Week : BaseEntity
{
    public uint WeekNumber { get; set; }
    
    public required Span Span { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly StartDate { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly EndDate { get; set; }
    
    public float Score { get; set; }
    
    public required IEnumerable<Day> Days { get; set; } = new List<Day>();
}