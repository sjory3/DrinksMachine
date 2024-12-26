using Website.Client.Pages;
using Website.Components;
using Website.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHttpClient();

builder.Services.AddSingleton<DrinkService>();
//builder.Services.AddSingleton<DrinkDataService>(); // Ensure this is Singleton
builder.Services.AddControllers();
builder.Services.AddHttpClient<DrinkDataService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:44349"); // Set the base address for the API
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("https://localhost:44349") // Adjust the origin as needed
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
