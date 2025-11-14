using ServiceTemplate.Domain.Interfaces;

namespace ServiceTemplate.Application.UseCases;

public class CreateUserUseCase(
    IUserService userService,
    IEmailService emailService,
    ILoggerService logger)
{
    public async Task ExecuteAsync(string username, string email)
    {
        var user = await userService.CreateUserAsync(username, email);
        await emailService.SendWelcomeEmailAsync(user.Email);
        await logger.LogAsync($"User {user.Username} created successfully at {DateTime.UtcNow}");
    }
}