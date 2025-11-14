

using Microsoft.OpenApi;

namespace ServiceTemplate.Web.Extensions;

public static class SwaggerExtensions
{
    /// <summary>
    /// Configures Swagger documentation and UI with API key authentication support.
    /// </summary>
    public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "MyService API",
                Version = "v1",
                Description = "API documentation for MyService"
            });
            
            var apiKeyScheme = new OpenApiSecurityScheme
            {
                Description = "Enter your API key below:",
                Name = "X-API-KEY",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "ApiKeyScheme"
            };
            
            c.AddSecurityDefinition("ApiKey", apiKeyScheme);
        });

        return services;
    }

    public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "MyService API v1");
            options.RoutePrefix = string.Empty; // Swagger at root
        });

        return app;
    }
}