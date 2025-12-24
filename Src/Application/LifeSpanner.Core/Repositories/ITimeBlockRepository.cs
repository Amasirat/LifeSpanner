using LifeSpanner.Domain.Entities;

namespace LifeSpanner.Core.Repositories;

public interface ITimeBlockRepository
{
    Task<IEnumerable<TimeBlock>> GetAllUserTimeBlocks(Guid userId);
    
    Task<TimeBlock> GetTimeBlockByIdAsync(Guid id);
    
    Task<TimeBlock> AddTimeBlockAsync(TimeBlock timeBlock);
    
    Task<TimeBlock> UpdateTimeBlockAsync(TimeBlock timeBlock);
    
    Task<bool> DeleteTimeBlockByIdAsync(Guid id);
}