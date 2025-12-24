using LifeSpanner.Domain.Entities;

namespace LifeSpanner.Core.Repositories;

public interface ITacticRepository
{
    Task<IEnumerable<Tactic>> GetAllUserTasksAsync(Guid userId);
    
    Task<Tactic> GetTaskByIdAsync(Guid id);
    
    Task<Tactic> CreateTaskAsync(Tactic task);
    
    Task<Tactic> UpdateTaskAsync(Tactic task);
    
    Task<bool> DeleteTaskByIdAsync(Guid id);
}