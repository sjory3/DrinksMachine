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
            return await _httpClient.GetFromJsonAsync<List<Liquid>>("data/Liquids.json");
        }

        public async Task<List<Alcohol>> GetAlcoholsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Alcohol>>("data/Alcohols.json");
        }
    }
}