namespace service_template.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;


    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }
}