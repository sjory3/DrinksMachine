using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


namespace Website.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44349") });

            await builder.Build().RunAsync();
        }
    }
}

