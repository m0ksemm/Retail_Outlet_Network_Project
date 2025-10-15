using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class StoresService : IStoresService
    {
        private readonly ApplicationDbContext _context;

        public StoresService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddStore(Store store)
        {
            List<Store>? stores = await GetStores();

            if (stores != null)
            {
                foreach (Store stor in stores)
                {
                    if (stor.StoreName == store.StoreName &&
                        stor.Address == store.Address)
                    {
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(store.StoreName) || string.IsNullOrEmpty(store.Address))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            _context.stores.Add(store);

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

        public async Task<bool> DeleteStore(Guid id)
        {
            var store = await _context.stores.FindAsync(id);
            if (store == null)
            {
                return false;
            }

            _context.stores.Remove(store);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Store?> GetStore(Guid id)
        {
            var sotre = await _context.stores.FirstOrDefaultAsync(temp => temp.StoreID == id);

            if (sotre == null)
            {
                return null;
            }

            return sotre;
        }

        public async Task<List<Store>?> GetStores()
        {
            List<Store> stores = await _context.stores.ToListAsync();
            if (stores == null)
            {
                return null;
            }
            else
            {
                return stores;
            }
        }

        public async Task<bool> UpdateStore(Guid id, Store store)
        {
            if (id != store.StoreID)
            {
                return false;
            }

            Store? existingStore = await _context.stores.FindAsync(id);
            if (existingStore == null)
            {
                return false;
            }
            List<Store>? stores = await GetStores();

            if (string.IsNullOrEmpty(store.StoreName) || string.IsNullOrEmpty(store.Address))
            {
                return false;
            }
            if (stores != null)
            {
                foreach (Store stor in stores)
                {
                    if (stor.StoreName == store.StoreName &&
                        stor.Address == store.Address) 
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            existingStore.StoreName = store.StoreName;
            existingStore.Address = store.Address;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool StoreExists(Guid id)
        {
            return _context.stores.Any(e => e.StoreID == id);
        }
    }
}
