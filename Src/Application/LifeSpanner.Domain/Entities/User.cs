using System.ComponentModel.DataAnnotations;
using LifeSpanner.Common.Types;

namespace LifeSpanner.Domain.Entities;

public class User : BaseEntity
{
    [MaxLength(50)]
    public required string Username { get; set; }
    
    [MaxLength(50), EmailAddress]
    public required string Email { get; set; }
    
    [MaxLength(256)]
    public required string PasswordHash { get; set; }
    
    [EnumDataType(typeof(UserRoleEnum))]
    public UserRoleEnum Role { get; set; }
    
    public DateTime? EmailVerifiedAt { get; set; }
    
    public ushort EndDayOffset { get; set; }
    
    public IEnumerable<Tactic> Tasks { get; set; } = new List<Tactic>();
    public IEnumerable<Goal> Goals { get; set; } = new List<Goal>();
    public IEnumerable<Span> Spans { get; set; } = new List<Span>();
    public IEnumerable<Project> Projects { get; set; } = new List<Project>();
    public IEnumerable<Tag> Tags { get; set; } = new List<Tag>();
    public IEnumerable<TimeBlock> TimeBlocks { get; set; } = new List<TimeBlock>();
    public IEnumerable<Event> Events { get; set; } = new List<Event>();
}