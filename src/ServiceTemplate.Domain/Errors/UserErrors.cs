namespace ServiceTemplate.Domain.Errors;

public static class UserErrors
{
    public static readonly Error NotFound = new("User.NotFound", "User not found.");
    public static readonly Error InvalidCredentials = new("User.InvalidCredentials", "Invalid credentials.");
    public static readonly Error AlreadyExists = new("User.AlreadyExists", "User already exists.");
    public static readonly Error PasswordInvalid = new("User.PasswordInvalid", "Password invalid.");
}