using ServiceTemplate.Domain.Entities;

namespace ServiceTemplate.Domain.Interfaces;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByEmailAsync(string email);
}