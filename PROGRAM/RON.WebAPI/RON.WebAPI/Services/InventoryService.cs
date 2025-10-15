using Humanizer;
using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ApplicationDbContext _context;

        public InventoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddInventory(Inventory inventory)
        { 
            if (string.IsNullOrEmpty(inventory.StoreID.ToString()) ||
                string.IsNullOrEmpty(inventory.ProductID.ToString()) ||
                inventory.Quantity <= 0)
            {
                return false;
            }
            List<Inventory>? allInventory = await GetAllInventory();
            if (allInventory != null)
            {
                foreach (Inventory inv in allInventory)
                {
                    if (inv.StoreID == inventory.StoreID &&
                        inv.ProductID == inventory.ProductID)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            _context.inventory.Add(inventory);

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

        public async Task<bool> DeleteInventory(Guid id)
        {
            var inventory = await _context.inventory.FindAsync(id);
            if (inventory == null)
            {
                return false;
            }

            _context.inventory.Remove(inventory);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Inventory?> GetInventory(Guid id)
        {
            var inventory = await _context.inventory.Include("Store").Include("Product").FirstOrDefaultAsync(temp => temp.InventoryID == id);

            if (inventory == null)
            {
                return null;
            }

            return inventory;
        }

        public async Task<List<Inventory>?> GetAllInventory()
        {
            List<Inventory> allInventory = await _context.inventory.Include("Store").Include("Product").ToListAsync();
            if (allInventory == null)
            {
                return null;
            }
            else
            {
                return allInventory;
            }
        }

        public async Task<bool> UpdateInventory(Guid id, Inventory inventory)
        {
            if (id != inventory.InventoryID)
            {
                return false;
            }

            Inventory? existingInventory = await _context.inventory.FindAsync(id);
            if (existingInventory == null)
            {
                return false;
            }
            List<Inventory>? allInventory = await GetAllInventory();

            if (string.IsNullOrEmpty(inventory.StoreID.ToString()) || 
                string.IsNullOrEmpty(inventory.ProductID.ToString()) ||
                inventory.Quantity <= 0)
            {
                return false;
            }

            if (allInventory != null)
            {
                foreach (Inventory inv in allInventory)
                {
                    if (inv.StoreID == inventory.StoreID &&
                        inv.ProductID == inventory.ProductID && 
                        inv.Quantity == inventory.Quantity)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            existingInventory.StoreID = inventory.StoreID;
            existingInventory.ProductID = inventory.ProductID;
            existingInventory.Quantity = inventory.Quantity;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool InventoryExists(Guid id)
        {
            return _context.inventory.Any(e => e.InventoryID == id);
        }
    }
}
