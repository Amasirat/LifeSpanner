using LifeSpanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeSpanner.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        BuildGoalSpans(modelBuilder);
    }

    private void BuildGoalSpans(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Span>().
            HasMany(s => s.Goals).
            WithMany(g => g.Spans).
            UsingEntity<GoalSpan>();
    }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Project> Projects { get; set; }
    
    public DbSet<Section> Sections { get; set; }
    
    public DbSet<Event> Events { get; set; }
    
    public DbSet<Tag> Tags { get; set; }
    
    public DbSet<TimeBlock> TimeBlocks { get; set; }
    
    public DbSet<Goal> Goals { get; set; }
    
    public DbSet<Span> Spans { get; set; }
    
    public DbSet<Domain.Entities.Tactic> Tasks { get; set; }
    
    public DbSet<Week> Weeks { get; set; }
    
    public DbSet<Day> Days { get; set; }
}