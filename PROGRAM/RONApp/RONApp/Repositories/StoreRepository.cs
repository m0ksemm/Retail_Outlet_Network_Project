using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class StoreRepository
    {
        private readonly HttpClient _httpClient;
        public StoreRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Store>> GetStores()
        {
            var sores = new List<Store>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/Stores");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            sores = JsonSerializer.Deserialize<List<Store>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return sores;
        }

        public async Task CreateStore(Store store)
        {
            var json = JsonSerializer.Serialize(store);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/Stores", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateStore(Store store)
        {
            var json = JsonSerializer.Serialize(store);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/Stores/{store.StoreID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteStore(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/Stores/{guid}");
        }
    }
}

