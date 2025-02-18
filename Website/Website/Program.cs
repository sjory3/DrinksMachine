using Microsoft.AspNetCore.Builder;
using Website.Components;
using Website.Services;

var builder = WebApplication.CreateBuilder(args);

// Load configuration
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHttpClient();

builder.Services.AddSingleton<DrinkDataService>(); // Ensure this is Singleton
builder.Services.AddControllers();
builder.Services.AddHttpClient<DrinkDataService>(client =>
{
    client.BaseAddress = new Uri(configuration["ApiBaseAddress"] ?? "http://localhost:44349"); // Set the base address for the API
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(configuration["Cors:AllowedOrigins"] ?? "http://localhost:5000") // Adjust the origin as needed
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Website.Client._Imports).Assembly);

app.Run();
