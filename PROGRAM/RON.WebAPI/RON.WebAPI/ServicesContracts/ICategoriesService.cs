using Microsoft.EntityFrameworkCore;
using RON.WebAPI.Models;

namespace RON.WebAPI.ServicesContracts
{
    public interface ICategoriesService
    {
        public Task<bool> AddCategory(Category category);
        public Task<bool> DeleteCategory(Guid id);
        public  Task<List<Category>?> GetCategories();
        public  Task<Category?> GetCategory(Guid id);
        public  Task<bool> UpdateCategory(Guid id, Category category);
    }
}
