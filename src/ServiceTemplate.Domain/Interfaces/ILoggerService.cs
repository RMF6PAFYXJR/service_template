namespace ServiceTemplate.Domain.Interfaces;

public interface ILoggerService
{
    Task LogAsync(string message);
}