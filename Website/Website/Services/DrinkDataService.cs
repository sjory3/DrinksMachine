using System.Net.Http.Json;
using Website.Models;
using Newtonsoft.Json;

namespace Website.Services
{
    public class DrinkDataService
    {
        private readonly HttpClient _httpClient;

        public DrinkDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Task> SaveDrinkAsync(Drink drink)
        {
            List<Drink> drinks = await GetDrinksAsync();
            drinks.Add(drink);
            string updatedJson = JsonConvert.SerializeObject(drinks, Formatting.Indented);
            await File.WriteAllTextAsync("wwwroot/data/Drinks.json", updatedJson);


            return Task.CompletedTask; // Placeholder for actual database logic
        }

        public async Task<List<Drink>> GetDrinksAsync()
        {
            // Fetch the JSON file directly from the wwwroot/data directory
            List<Drink>? drinks = await _httpClient.GetFromJsonAsync<List<Drink>>("data/Drinks.json");
            return drinks ?? new List<Drink>(); // Handle possible null reference return
        }

        public async Task<List<Liquid>> GetLiquidsAsync()
        {
            // Fetch the JSON file directly from the wwwroot/data directory
            List<Liquid>? liquids = await _httpClient.GetFromJsonAsync<List<Liquid>>("data/Liquids.json");
            return liquids ?? new List<Liquid>(); // Handle possible null reference return
        }

        public async Task<List<Alcohol>> GetAlcoholsAsync()
        {
            // Fetch the JSON file directly from the wwwroot/data directory
            List<Alcohol>? alcohols = await _httpClient.GetFromJsonAsync<List<Alcohol>>("data/Alcohols.json");
            return alcohols ?? new List<Alcohol>(); // Handle possible null reference return
        }
    }
}
