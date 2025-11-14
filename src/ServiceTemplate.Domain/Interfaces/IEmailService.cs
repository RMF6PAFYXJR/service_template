namespace ServiceTemplate.Domain.Interfaces;

public interface IEmailService
{
    Task SendWelcomeEmailAsync(string email);
}