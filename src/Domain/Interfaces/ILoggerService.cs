namespace service_template.Domain.Interfaces;

public interface ILoggerService
{
    Task LogAsync(string message);
}