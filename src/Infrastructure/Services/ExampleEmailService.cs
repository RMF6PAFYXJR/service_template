using service_template.Domain.Interfaces;

namespace service_template.Infrastructure.Services;

public class ExampleEmailService : IEmailService
{
    public async Task SendWelcomeEmailAsync(string email)
    {
        Console.WriteLine($"Sending welcome email to {email}");
        await Task.CompletedTask;
    }
}