using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class UsersRepository
    {
        private readonly HttpClient _httpClient;
        public UsersRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Models.User>> GetUsers()
        {
            var users = new List<Models.User>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/Users");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            users = JsonSerializer.Deserialize<List<Models.User>> (json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return users;
        }

        public async Task CreateUser(User user)
        {
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/Users", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateUser(User user)
        {
            var json = JsonSerializer.Serialize(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/Users/{user.UserID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteUser(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/Users/{guid}");
        }
    }
}
