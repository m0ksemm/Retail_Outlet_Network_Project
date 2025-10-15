using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface IInventoryService
    {
        public Task<bool> AddInventory(Inventory inventory);
        public Task<bool> DeleteInventory(Guid id);
        public Task<List<Inventory>?> GetAllInventory();
        public Task<Inventory?> GetInventory(Guid id);
        public Task<bool> UpdateInventory(Guid id, Inventory inventory);
    }
}
