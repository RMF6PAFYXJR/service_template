using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace ServiceTemplate.Web.Extensions;

public static class SwaggerExtensions
{
    /// <summary>
    /// Registers Swagger services with API key support.
    /// </summary>
    public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services, IConfiguration config)
    {
        var title = config["Swagger:Title"] ?? "ServiceTemplate API";
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = title,
                Version = "v1",
                Description = $"API documentation for {title}"
            });
            
            options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
            {
                Description = "Enter your API key below:",
                Name = "X-API-KEY",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "ApiKeyScheme"
            });

            options.AddSecurityRequirement((document) => new OpenApiSecurityRequirement
            {
                [new OpenApiSecuritySchemeReference("ApiKey", document)] = []
            });
        });

        return services;
    }
    
    public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app, IConfiguration config)
    {
        var title = config["Swagger:Title"] ?? "ServiceTemplate API";
        
        app.UseSwagger(options =>
        {
            options.OpenApiVersion = OpenApiSpecVersion.OpenApi3_1;
        });
        app.UseSwaggerUI(options =>
        {
            options.DefaultModelExpandDepth(2);
            options.DefaultModelRendering(ModelRendering.Model);
            options.DefaultModelsExpandDepth(-1);
            options.DisplayOperationId();
            options.DisplayRequestDuration();
            options.DocExpansion(DocExpansion.None);
            options.EnableDeepLinking();
            options.EnableFilter();
            options.EnablePersistAuthorization();
            options.EnableTryItOutByDefault();
            options.MaxDisplayedTags(5);
            options.ShowExtensions();
            options.ShowCommonExtensions();
            options.EnableValidator();
            options.SupportedSubmitMethods(SubmitMethod.Get, SubmitMethod.Head);
            options.UseRequestInterceptor("(request) => { return request; }");
            options.UseResponseInterceptor("(response) => { return response; }");
        });
        return app;
    }
    
    public static bool IsSwaggerPath(string path)
    {
        return path.StartsWith("/swagger/", StringComparison.OrdinalIgnoreCase);  
    }
}