namespace service_template.Domain.Interfaces;

using Domain.Entities;


public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByEmailAsync(string email);
}