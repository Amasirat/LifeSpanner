using LifeSpanner.Domain.Entities;

namespace LifeSpanner.Core.Repositories;

public interface IGoalRepository
{
    Task<IEnumerable<Goal>> GetAllUserGoalsAsync(Guid userId);
    
    Task<Goal> GetUserGoalByIdAsync(Guid id);
    
    Task<Goal> AddGoalAsync(Goal goal);
    
    Task<Goal> UpdateGoalAsync(Goal goal);
    
    Task<bool> DeleteGoalAsync(Guid id);
}