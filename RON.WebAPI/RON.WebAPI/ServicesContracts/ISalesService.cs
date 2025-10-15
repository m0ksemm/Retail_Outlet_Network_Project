using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface ISalesService
    {
        public Task<bool> AddSale(Sale sale);
        public Task<bool> DeleteSale(Guid id);
        public Task<List<Sale>?> GetSales();
        public Task<Sale?> GetSale(Guid id);
        public Task<bool> UpdateSale(Guid id, Sale sale);
    }
}
