namespace LifeSpanner.Domain.Entities;

public class TimeBlock : BaseEntity
{
    public required User User { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public uint Capacity { get; set; }
    
    public Tag? Tag { get; set; }
}