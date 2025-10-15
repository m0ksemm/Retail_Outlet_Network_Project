using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface ISaleProductService
    {
        public Task<bool> AddSaleProduct(SaleProduct saleProduct);
        public Task<bool> DeleteSaleProduct(Guid id);
        public Task<List<SaleProduct>?> GetSalesProducts();
        public Task<SaleProduct?> GetSaleProduct(Guid id);
        public Task<bool> UpdateSaleProduct(Guid id, SaleProduct saleProduct);
    }
}
