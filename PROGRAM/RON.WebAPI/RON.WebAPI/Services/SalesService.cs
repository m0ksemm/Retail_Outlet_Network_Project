using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class SalesService : ISalesService
    {
        private readonly ApplicationDbContext _context;

        public SalesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddSale(Sale sale)
        {
            if (string.IsNullOrEmpty(sale.UserID.ToString()) ||
                string.IsNullOrEmpty(sale.StoreID.ToString()) ||
                sale.Total <= 0)
            {
                return false;
            }
            List<Sale>? allSales = await GetSales();
            if (allSales != null)
            {
                foreach (Sale sal in allSales)
                {
                    if (sal.StoreID == sale.StoreID &&
                        sal.UserID == sale.UserID &&
                        sal.Total == sale.Total)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            _context.sales.Add(sale);

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

        public async Task<bool> DeleteSale(Guid id)
        {
            var sale = await _context.sales.FindAsync(id);
            if (sale == null)
            {
                return false;
            }

            _context.sales.Remove(sale);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Sale?> GetSale(Guid id)
        {
            var sale = await _context.sales.Include("Store").Include("User").FirstOrDefaultAsync(temp => temp.SaleID == id);

            if (sale == null)
            {
                return null;
            }
            return sale;
        }

        public async Task<List<Sale>?> GetSales()
        {
            List<Sale> allSales = await _context.sales.Include("Store").Include("User").ToListAsync();
            if (allSales == null)
            {
                return null;
            }
            else
            {
                return allSales;
            }
        }

        public async Task<bool> UpdateSale(Guid id, Sale sale)
        {
            if (id != sale.SaleID)
            {
                return false;
            }

            if (string.IsNullOrEmpty(sale.UserID.ToString()) ||
                string.IsNullOrEmpty(sale.StoreID.ToString()) ||
                sale.Total <= 0)
            {
                return false;
            }

            Sale? existingSale = await _context.sales.FindAsync(id);
            if (existingSale == null)
            {
                return false;
            }
            List<Sale>? allSale = await GetSales();


            if (allSale != null)
            {
                foreach (Sale sal in allSale)
                {
                    if (sal.StoreID == sale.StoreID &&
                        sal.UserID == sale.UserID &&
                        sal.Total == sale.Total)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            existingSale.StoreID = sale.StoreID;
            existingSale.UserID = sale.UserID;
            existingSale.Total = sale.Total;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool SaleExists(Guid id)
        {
            return _context.sales.Any(e => e.SaleID == id);
        }
    }
}

