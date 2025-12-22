using System.ComponentModel.DataAnnotations;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Domain.Entities;

public class GoalSpan : BaseEntity
{
    [EnumDataType(typeof(GoalStatusEnum))]
    public GoalStatusEnum Status { get; set; }
    
    public double Score { get; set; }
}