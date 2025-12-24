using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Core.Dtos.Span;

public class CreateSpanDto
{
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public DateOnly StartDate { get; set; }
    
    public DateOnly EndDate { get; set; }
}