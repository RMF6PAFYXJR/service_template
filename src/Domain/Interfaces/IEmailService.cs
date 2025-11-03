namespace service_template.Domain.Interfaces;

public interface IEmailService
{
    Task SendWelcomeEmailAsync(string email);
}