using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Domain.Entities;

public class Task : BaseEntity
{
    [MaxLength(50)]
    public required string Title { get; set; }

    public required User User { get; set; }
    
    public Goal? Goal { get; set; }
    
    public Section? Section { get; set; }
    
    public uint Count { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly DueDate { get; set; }
    
    [EnumDataType(typeof(TaskTypeEnum))]
    public TaskTypeEnum Type { get; set; }
    
    [EnumDataType(typeof(TaskPriorityEnum))]
    public TaskPriorityEnum Priority { get; set; }
    
    public uint Complexity { get; set; }
    
    [MaxLength(64)]
    public string? MergeHash { get; set; }
    
    public float CompletionScore { get; set; }
    
    public Project? Project { get; set; }
    
    public TimeBlock? TimeBlock { get; set; }
    
    public Day? Day { get; set; }
}