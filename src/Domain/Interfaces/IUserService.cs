using service_template.Domain.Entities;

namespace service_template.Domain.Interfaces;

public interface IUserService
{
    Task<User> CreateUserAsync(string username, string email);
}