using service_template.Domain.Entities;
using service_template.Domain.Interfaces;
using service_template.Infrastructure.Persistence;

namespace service_template.Infrastructure.Services;

public class ExampleUserService(IUserRepository users) : IUserService
{
    public async Task<User> CreateUserAsync(string username, string email)
    {
        var user = new User(username, email);
        await users.AddAsync(user);
        return user;
    }
}