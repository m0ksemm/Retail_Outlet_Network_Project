using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class InventoryRepository
    {
        private readonly HttpClient _httpClient;
        public InventoryRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Inventory>> GetAllInventory()
        {
            var invetory = new List<Inventory>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/Inventory");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            invetory = JsonSerializer.Deserialize<List<Inventory>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return invetory;
        }

        public async Task CreateInventory(Inventory inventory)
        {
            var json = JsonSerializer.Serialize(inventory);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/Inventory", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateInventory(Inventory inventory)
        {
            var json = JsonSerializer.Serialize(inventory);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/Inventory/{inventory.InventoryID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteInventory(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/Inventory/{guid}");
            response.EnsureSuccessStatusCode();
        }
    }
}
