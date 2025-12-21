using System.ComponentModel.DataAnnotations;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Domain.Entities;

public class GoalSpan : BaseEntity
{
    public int SpanId { get; set; }
    
    public int GoalId { get; set; }
    
    [EnumDataType(typeof(GoalStatusEnum))]
    public GoalStatusEnum Status { get; set; }
    
    public double Score { get; set; }
}