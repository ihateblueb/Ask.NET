using Ask.NET.Core;
using Ask.NET.Components;
using Microsoft.EntityFrameworkCore;

namespace Ask.NET;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddJsonFile(Environment.GetEnvironmentVariable("ASKNET_CONFIG") ?? "configuration.json", optional: false, reloadOnChange: true);

        var connectionString = "postgres://";
        connectionString += builder.Configuration.GetSection("Database").GetValue<string>("User");
        connectionString += "@";
        connectionString += builder.Configuration.GetSection("Database").GetValue<string>("Password");
        connectionString += "@";
        connectionString += builder.Configuration.GetSection("Database").GetValue<string>("Host");
        connectionString += ":";
        connectionString += builder.Configuration.GetSection("Database").GetValue<string>("Port");
        connectionString += "/";
        connectionString += builder.Configuration.GetSection("Database").GetValue<string>("Name");

        builder.Services.AddDbContext<Context>(options =>
            options.UseNpgsql(connectionString));

        builder.Services.AddControllers();

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            app.UseHsts();
        }

        app.UseAntiforgery();
        app.MapControllers();

        app.MapStaticAssets();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run($"http://{app.Configuration.GetValue<string>("Host")}:{app.Configuration.GetValue<string>("Port")}");
    }
}