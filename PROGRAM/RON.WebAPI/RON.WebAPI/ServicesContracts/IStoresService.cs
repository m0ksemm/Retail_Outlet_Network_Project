using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface IStoresService
    {
        public Task<bool> AddStore(Store store);
        public Task<bool> DeleteStore(Guid id);
        public Task<List<Store>?> GetStores();
        public Task<Store?> GetStore(Guid id);
        public Task<bool> UpdateStore(Guid id, Store store);
    }
}
