using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class SaleProductRepository
    {
        private readonly HttpClient _httpClient;
        public SaleProductRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<SaleProduct>> GetSaleProducts()
        {
            var salesprods = new List<SaleProduct>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/SaleProducts");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            salesprods = JsonSerializer.Deserialize<List<SaleProduct>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return salesprods;
        }

        public async Task CreateSaleProduct(SaleProduct saleProduct)
        {
            var json = JsonSerializer.Serialize(saleProduct);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/SaleProducts", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateSaleProduct(SaleProduct SaleProduct)
        {
            var json = JsonSerializer.Serialize(SaleProduct);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/SaleProducts/{SaleProduct.SaleProductID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteSaleProduct(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/SaleProducts/{guid}");
        }
    }
}

