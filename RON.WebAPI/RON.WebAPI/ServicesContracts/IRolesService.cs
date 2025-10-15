using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface IRolesService
    {
        public Task<bool> AddRole(Role role);
        public Task<bool> DeleteRole(Guid id);
        public Task<List<Role>?> GetRoles();
        public Task<Role?> GetRole(Guid id);
        public Task<bool> UpdateRole(Guid id, Role role);
    }
}
