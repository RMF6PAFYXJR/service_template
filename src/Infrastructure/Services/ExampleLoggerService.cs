using service_template.Domain.Interfaces;

namespace service_template.Infrastructure.Services;


public class ExampleLoggerService : ILoggerService
{
    public async Task LogAsync(string message)
    {
        Console.WriteLine($"[Logger] {message}");
        await Task.CompletedTask;
    }
}