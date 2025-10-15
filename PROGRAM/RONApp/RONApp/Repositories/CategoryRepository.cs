using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class CategoryRepository
    {
        private readonly HttpClient _httpClient;  // Ін'єкція класу HttpClient
        public CategoryRepository()               // Конструктор
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Category>> GetCategories()   // Метод для отримання всіх
        {                                                   // каткгорій з бази даних
            var categories = new List<Category>();

            var response = await _httpClient                        // Надсилання запиту
                .GetAsync("https://localhost:7015/api/Categories"); // Посилання на API
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();   // Отримання результату
            categories = JsonSerializer                     // Десеріалізація отрианих даних
                .Deserialize<List<Category>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return categories;          // Поверення колекції класів Category
        } 

        public async Task CreateCategory(Category category) // Метод для створення категорії
        {
            var json = JsonSerializer.Serialize(category);      // Серіалізація даних
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient      // Відсилання запиту із серіалізованими даними
                .PostAsync("https://localhost:7015/api/Categories", content);
            response.EnsureSuccessStatusCode();    // Перевірка запиту на успіх
        }
        public async Task UpdateCategory(Category category)     // Метод для оновлення категорії
        {
            var json = JsonSerializer.Serialize(category);      // Серіалізація даних
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient        // Відсилання запиту із серіалізованими даними
                .PutAsync($"https://localhost:7015/api/Categories/{category.CategoryID}", content);
            response.EnsureSuccessStatusCode();     // Перевірка запиту на успіх
        }
        public async Task DeleteCategory(Guid guid)     // Метод для видалення категорії
        {
            var response = await _httpClient                // Відсилання запиту разом з Guid значенням 
                .DeleteAsync($"https://localhost:7015/api/Categories/{guid}"); // об'єкту для видалення
        }
    }
}
