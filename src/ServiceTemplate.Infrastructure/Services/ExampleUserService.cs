using ServiceTemplate.Domain.Entities;
using ServiceTemplate.Domain.Interfaces;

namespace ServiceTemplate.Infrastructure.Services;

public class ExampleUserService(IUserRepository users) : IUserService
{
    public async Task<User> CreateUserAsync(string username, string email)
    {
        var user = new User(username, email);
        await users.AddAsync(user);
        return user;
    }
}