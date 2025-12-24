using LifeSpanner.Domain.Entities;

namespace LifeSpanner.Core.Repositories;

public interface ISpanRepository
{
    Task<IEnumerable<Span>> GetAllUserSpansAsync(Guid userId);
    
    Task<Span> GetUserSpanByIdAsync(Guid id);
    
    Task<Span> AddUserSpanAsync(Span span);
    
    Task<Span> UpdateSpanAsync(Span span);
    
    Task<bool> DeleteSpanAsync(Span span);
}