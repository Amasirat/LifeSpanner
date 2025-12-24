using System.ComponentModel.DataAnnotations;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Core.Dtos.Task;

public class TacticDto
{
    public Guid Id { get; set; }
    
    [MaxLength(50)]
    public required string Title { get; set; }
    
    public uint Count { get; set; }
    
    public TaskPriorityEnum Priority { get; set; }
    
    public uint Complexity { get; set; }
    
    public float CompletionScore { get; set; }
}