using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface IProductsService
    {
        public Task<bool> AddProduct(Product product);
        public Task<bool> DeleteProduct(Guid id);
        public Task<List<Product>?> GetProducts();
        public Task<Product?> GetProduct(Guid id);
        public Task<bool> UpdateProduct(Guid id, Product product);
    }
}
