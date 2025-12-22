using LifeSpanner.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LifeSpanner.API;
public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        ConfigureDatabase(builder);
        
        ConfigureServices(builder.Services);
        
        ConfigureSwagger(builder);
        
        var app = builder.Build();
        
        AddMiddleware(app);
        
        app.Run();
    }

    private static void ConfigureDatabase(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseNpgsql(connectionString: builder.Configuration["ConnectionStrings:Dev"]);
        });
    }

    private static void ConfigureSwagger(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddOpenApi();
        services.AddControllers();
    }

    private static void AddMiddleware(WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                opt.RoutePrefix = string.Empty;
            });
        }

        if (app.Environment.IsProduction())
        {
            app.UseHttpsRedirection();
        }

        app.MapControllers();
    }
}


record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}