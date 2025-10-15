using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RONApp.Models;

namespace RONApp.Repositories
{
    public class RoleRepository
    {
        private readonly HttpClient _httpClient;
        public RoleRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Role>> GetRoles()
        {
            var roles = new List<Role>();

            var response = await _httpClient.GetAsync("https://localhost:7015/api/Roles");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            roles = JsonSerializer.Deserialize<List<Role>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return roles;
        }

        public async Task CreateRole(Role role)
        {
            var json = JsonSerializer.Serialize(role);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7015/api/Roles", content);
            response.EnsureSuccessStatusCode();


        }
        public async Task UpdateRole(Role role)
        {
            var json = JsonSerializer.Serialize(role);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7015/api/Roles/{role.RoleID}", content);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteRole(Guid guid)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7015/api/Roles/{guid}");
        }
    }
}
