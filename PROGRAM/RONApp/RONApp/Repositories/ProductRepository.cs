using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class ProductRepository
    {
        private readonly HttpClient _httpClient;
        public ProductRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Product>> GetProducts()
        {
            var products = new List<Product>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/Products");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return products;
        }

        public async Task CreateProduct(Product product)
        {
            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/Products", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateProduct(Product product)
        {
            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/Products/{product.ProductID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteProduct(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/Products/{guid}");
        }
    }
}
