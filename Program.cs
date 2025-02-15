using Ask.NET.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Configuration.AddJsonFile(Environment.GetEnvironmentVariable("ASKNET_CONFIGURATION") ?? "appsettings.json", optional: false, reloadOnChange: true);
builder.Services.Configure<Config>(builder.Configuration.GetSection("AskNET"));

var app = builder.Build();

app.UseExceptionHandler("/Error");
app.UseHsts();

app.MapControllers();

app.UseHttpsRedirection();

app.UseRouting();

app.MapStaticAssets();
app.MapRazorPages()
    .WithStaticAssets();

app.Run();