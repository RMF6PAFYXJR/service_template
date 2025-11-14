using ServiceTemplate.Domain.Interfaces;

namespace ServiceTemplate.Infrastructure.Services;

public class ExampleEmailService : IEmailService
{
    public async Task SendWelcomeEmailAsync(string email)
    {
        Console.WriteLine($"Sending welcome email to {email}");
        await Task.CompletedTask;
    }
}