using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Website.Client.Models;

namespace Website.Client.Services
{
    public class DrinkDataService2
    {
        private readonly HttpClient _httpClient;

        public DrinkDataService2(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Liquid>> GetLiquidsAsync()
        {
            var liquids = await _httpClient.GetFromJsonAsync<List<Liquid>>("api/drinks/liquids");
            return liquids ?? new List<Liquid>(); // Handle possible null reference return
        }

        public async Task<List<Alcohol>> GetAlcoholsAsync()
        {
            var alcohols = await _httpClient.GetFromJsonAsync<List<Alcohol>>("api/drinks/alcohols");
            return alcohols ?? new List<Alcohol>(); // Handle possible null reference return
        }
    }
}

