using service_template.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddForwardedHeadersSupport()
    .AddInfrastructure(builder.Configuration)
    .AddSwaggerDocumentation();

var app = builder.Build();

app
    .UseForwardedHeaders()
    .ApplyMigrations()
    .UseGlobalMiddlewares()
    .UseSwaggerDocumentation();

app
    .MapHealthEndpoints()
    .MapControllers();

app.Run();