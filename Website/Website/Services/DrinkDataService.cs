using System.Net.Http.Json;
using Website.Client.Models;

namespace Website.Services
{
    public class DrinkDataService
    {
        private readonly HttpClient _httpClient;

        public DrinkDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Liquid>> GetLiquidsAsync()
        {
            List<Liquid>? liquids = await _httpClient.GetFromJsonAsync<List<Liquid>>("api/drinks/liquids");
            return liquids ?? new List<Liquid>(); // Handle possible null reference return
        }

        public async Task<List<Alcohol>> GetAlcoholsAsync()
        {
            List<Alcohol>? alcohols = await _httpClient.GetFromJsonAsync<List<Alcohol>>("api/drinks/alcohols");
            return alcohols ?? new List<Alcohol>(); // Handle possible null reference return
        }
    }

}