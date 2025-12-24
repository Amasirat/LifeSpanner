using System.Data;
using LifeSpanner.Domain.Entities;

namespace LifeSpanner.Core.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    
    Task<User> GetUserByIdAsync(Guid id);
    
    Task<User> GetUserByEmailAsync(string email);
    
    Task<User> GetUserByUsernameAsync(string username);
    
    Task<User> CreateUserAsync(User user);
    
    Task<User> UpdateUserAsync(User user);
    
    Task<bool> DeleteUserByIdAsync(Guid id);
}