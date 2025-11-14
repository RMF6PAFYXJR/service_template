using ServiceTemplate.Domain.Interfaces;

namespace ServiceTemplate.Infrastructure.Services;


public class ExampleLoggerService : ILoggerService
{
    public async Task LogAsync(string message)
    {
        Console.WriteLine($"[Logger] {message}");
        await Task.CompletedTask;
    }
}