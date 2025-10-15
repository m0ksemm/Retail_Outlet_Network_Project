using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class RolesService : IRolesService
    {
        private readonly ApplicationDbContext _context;

        public RolesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddRole(Role role)
        {
            List<Role>? roles = await GetRoles();

            if (roles != null)
            {
                foreach (Role rol in roles)
                {
                    if (rol.RoleName == role.RoleName)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            _context.roles.Add(role);

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRole(Guid id)
        {
            var role = await _context.roles.FindAsync(id);
            if (role == null)
            {
                return false;
            }

            _context.roles.Remove(role);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Role>?> GetRoles()
        {
            List<Role> roles = await _context.roles.ToListAsync();
            if (roles == null)
            {
                return null;
            }
            else
            {
                return roles;
            }
        }

        public async Task<Role?> GetRole(Guid id)
        {
            var role = await _context.roles.FindAsync(id);

            if (role == null)
            {
                return null;
            }

            return role;
        }

        public async Task<bool> UpdateRole(Guid id, Role role)
        {
            if (id != role.RoleID)
            {
                return false;
            }

            Role? existingRole = await _context.roles.FindAsync(id);
            if (existingRole == null)
            {
                return false;
            }

            Role? sameRole = await _context.roles.FirstOrDefaultAsync(temp => temp.RoleName == role.RoleName);
            if (sameRole != null)
            {
                return false;
            }
            existingRole.RoleName = role.RoleName;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }
        private bool RoleExists(Guid id)
        {
            return _context.roles.Any(e => e.RoleID == id);
        }
    }
}
