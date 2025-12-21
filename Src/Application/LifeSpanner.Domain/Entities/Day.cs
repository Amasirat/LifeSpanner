namespace LifeSpanner.Domain.Entities;

public class Day : BaseEntity
{
    public uint DayNumber { get; set; }
    
    public required Week Week { get; set; }
    
    public DateOnly Date { get; set; }
    
    public DayOfWeek DayOfWeek { get; set; }
    
    public float Score { get; set; }
}