using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface IUsersService
    {
        public Task<bool> AddUser(User user);
        public Task<bool> DeleteUser(Guid id);
        public Task<List<User>?> GetUsers();
        public Task<User?> GetUser(Guid id);
        public Task<bool> UpdateUser(Guid id, User user);
    }
}
