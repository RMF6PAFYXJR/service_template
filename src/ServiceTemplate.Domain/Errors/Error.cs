namespace ServiceTemplate.Domain.Errors;

public class Error(string code, string message)
{
    public string Code { get; } = code;
    public string Message { get; } = message;

    public override string ToString() => $"{Code}: {Message}";
}