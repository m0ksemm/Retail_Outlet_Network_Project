using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class SalesRepository
    {
        private readonly HttpClient _httpClient;
        public SalesRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Sale>> GetSales()
        {
            var sales = new List<Sale>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/Sales");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            sales = JsonSerializer.Deserialize<List<Sale>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return sales;
        }

        public async Task CreateSale(Sale sale)
        {
            var json = JsonSerializer.Serialize(sale);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/Sales", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateSale(Sale sale)
        {
            var json = JsonSerializer.Serialize(sale);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/Sales/{sale.SaleID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteSale(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/Sales/{guid}");
        }
    }
}
