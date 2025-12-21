using System.ComponentModel.DataAnnotations;

namespace LifeSpanner.Domain.Entities;

public class Event : BaseEntity
{
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public required User User { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
}