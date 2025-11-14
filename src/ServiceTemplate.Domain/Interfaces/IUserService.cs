using ServiceTemplate.Domain.Entities;

namespace ServiceTemplate.Domain.Interfaces;

public interface IUserService
{
    Task<User> CreateUserAsync(string username, string email);
}