using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class SaleProductService : ISaleProductService
    {
        private readonly ApplicationDbContext _context;

        public SaleProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddSaleProduct(SaleProduct saleProduct)
        {
            if (string.IsNullOrEmpty(saleProduct.SaleID.ToString()) ||
                string.IsNullOrEmpty(saleProduct.ProductID.ToString()) ||
                saleProduct.Quantity <= 0 &&
                saleProduct.Price <= 0)

            {
                return false;
            }
            List<SaleProduct>? allSalesProducts = await GetSalesProducts();
            if (allSalesProducts != null)
            {
                foreach (SaleProduct salprod in allSalesProducts)
                {
                    if (salprod.SaleID == saleProduct.SaleID &&
                        salprod.ProductID == saleProduct.ProductID &&
                        salprod.Quantity == saleProduct.Quantity &&
                        salprod.Price == saleProduct.Price)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            _context.saleproducts.Add(saleProduct);

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

        public async Task<bool> DeleteSaleProduct(Guid id)
        {
            var saleproduct = await _context.saleproducts.FindAsync(id);
            if (saleproduct == null)
            {
                return false;
            }

            _context.saleproducts.Remove(saleproduct);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<SaleProduct?> GetSaleProduct(Guid id)
        {
            var saleProduct = await _context.saleproducts.Include("Sale").Include("Product").FirstOrDefaultAsync(temp => temp.SaleProductID == id);

            if (saleProduct == null)
            {
                return null;
            }
            return saleProduct;
        }

        public async Task<List<SaleProduct>?> GetSalesProducts()
        {
            List<SaleProduct> allSalesProducts = await _context.saleproducts.Include("Sale").Include("Product").ToListAsync();
            if (allSalesProducts == null)
            {
                return null;
            }
            else
            {
                return allSalesProducts;
            }
        }

        public async Task<bool> UpdateSaleProduct(Guid id, SaleProduct saleProduct)
        {
            if (id != saleProduct.SaleProductID)
            {
                return false;
            }

            if (string.IsNullOrEmpty(saleProduct.SaleID.ToString()) ||
                string.IsNullOrEmpty(saleProduct.ProductID.ToString()) ||
                saleProduct.Quantity <= 0 &&
                saleProduct.Price <= 0)
            {
                return false;
            }

            SaleProduct? existingSale = await _context.saleproducts.FindAsync(id);
            if (existingSale == null)
            {
                return false;
            }
            List<SaleProduct>? allSalesProducts = await GetSalesProducts();


            if (allSalesProducts != null)
            {
                foreach (SaleProduct salprod in allSalesProducts)
                {
                    if (salprod.SaleID == saleProduct.SaleID &&
                        salprod.ProductID == saleProduct.ProductID &&
                        salprod.Quantity == saleProduct.Quantity &&
                        salprod.Price == saleProduct.Price)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            existingSale.SaleID = saleProduct.SaleID;
            existingSale.ProductID = saleProduct.ProductID;
            existingSale.Quantity = saleProduct.Quantity;
            existingSale.Price = saleProduct.Price;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleProductExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool SaleProductExists(Guid id)
        {
            return _context.saleproducts.Any(e => e.SaleID == id);
        }
    }
}

