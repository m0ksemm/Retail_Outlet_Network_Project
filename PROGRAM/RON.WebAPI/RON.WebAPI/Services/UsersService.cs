using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext _context;

        public UsersService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddUser(User user)
        {
            if (string.IsNullOrEmpty(user.RoleID.ToString()) ||
                string.IsNullOrEmpty(user.UserFullName) || 
                string.IsNullOrEmpty(user.UserName) ||
                string.IsNullOrEmpty(user.PasswordHash))
            {
                return false;
            }
            List<User>? allUsers = await GetUsers();
            if (allUsers != null)
            {
                foreach (User us in allUsers)
                {
                    if (us.UserName == user.UserName)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            _context.users.Add(user);

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

        public async Task<bool> DeleteUser(Guid id)
        {
            var user = await _context.users.FindAsync(id);
            if (user == null)
            {
                return false;
            }

            _context.users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User?> GetUser(Guid id)
        {
            var user = await _context.users.Include("Role").FirstOrDefaultAsync(temp => temp.UserID == id);

            if (user == null)
            {
                return null;
            }
            return user;
        }

        public async Task<List<User>?> GetUsers()
        {
            List<User> allUsers = await _context.users.Include("Role").ToListAsync();
            if (allUsers == null)
            {
                return null;
            }
            else
            {
                return allUsers;
            }
        }

        public async Task<bool> UpdateUser(Guid id, User user)
        {
            if (id != user.UserID)
            {
                return false;
            }

            if (string.IsNullOrEmpty(user.RoleID.ToString()) ||
                string.IsNullOrEmpty(user.UserFullName) ||
                string.IsNullOrEmpty(user.UserName) ||
                string.IsNullOrEmpty(user.PasswordHash))
            {
                return false;
            }

            User? existingUser = await _context.users.FindAsync(id);
            if (existingUser == null)
            {
                return false;
            }
            List<User>? allUsers = await GetUsers();
            

            if (allUsers != null)
            {
                foreach (User us in allUsers)
                {
                    if (us.UserName == user.UserName &&
                        us.UserFullName == user.UserFullName &&
                        us.RoleID == user.RoleID &&
                        us.PasswordHash == user.PasswordHash)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            existingUser.UserFullName = user.UserFullName;
            existingUser.UserName = user.UserName;
            existingUser.PasswordHash = user.PasswordHash;
            existingUser.RoleID = user.RoleID;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool UserExists(Guid id)
        {
            return _context.users.Any(e => e.UserID == id);
        }
    }
}
