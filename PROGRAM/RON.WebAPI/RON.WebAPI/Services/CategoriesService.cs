using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext _context;

        public CategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddCategory(Category category)
        {
            // category.CategoryID = Guid.NewGuid();

            List<Category>? categories = await GetCategories();

            if (categories != null)
            {
                foreach (Category categ in categories)
                {
                    if (categ.CategoryName == category.CategoryName)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            _context.categories.Add(category);

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

        public async Task<bool> DeleteCategory(Guid id)
        {
            var category = await _context.categories.FindAsync(id);
            if (category == null)
            {
                return false;
            }

            _context.categories.Remove(category);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Category>?> GetCategories()
        {
            List<Category> categories = await _context.categories.ToListAsync();
            if (categories == null) 
            {
                return null;
            }
            else 
            {
                return categories;
            }
        }

        public async Task<Category?> GetCategory(Guid id)
        {
            var category = await _context.categories.FindAsync(id);

            if (category == null)
            {
                return null;
            }

            return category;
        }

        public async Task<bool> UpdateCategory(Guid id, Category category)
        {
            if (id != category.CategoryID)
            {
                return false;
            }

            Category? existingCategory = await _context.categories.FindAsync(id);
            if (existingCategory == null)
            {
                return false;
            }

            Category? sameCategory = await _context.categories.FirstOrDefaultAsync(temp => temp.CategoryName == category.CategoryName);
            if (sameCategory != null)
            {
                return false;
            }


            existingCategory.CategoryName = category.CategoryName;


            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }
        private bool CategoryExists(Guid id)
        {
            return _context.categories.Any(e => e.CategoryID == id);
        }
    }
}
