using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext _context; // Ін'єкція класу DbContext звязку з БД
        public ProductsService(ApplicationDbContext context) // Конструктор класу
        {
            _context = context;
        }
        public async Task<bool> AddProduct(Product product) // Метод додаваня продукту
        {
            List<Product>? products = await GetProducts(); // Отримання всіх існуючих продуктів
            if (products != null)
            {
                foreach (Product prod in products)
                {
                    if (prod.ProductName == product.ProductName &&  // Перевірка, чи не існує
                        prod.Price == product.Price &&              // такого ж самого продукту
                        prod.SKU == product.SKU &&                  // в базі даних.
                        prod.CategoryID == product.CategoryID)
                    {
                        return false;   
                    }
                }
                if (product.Price <= 0)                 // Перевірка, чи не є ціна      
                {                                       // продукту від'ємною
                    return false;
                }
            }
            _context.products.Add(product);             // Додавання продукту
            try                                         // Спроба зберегти змінні в БД
            {
                await _context.SaveChangesAsync();      // Збереження змін
                return true;
            }
            catch (DbUpdateConcurrencyException)  
            {
                return false;
            }
        }
        public async Task<bool> DeleteProduct(Guid id)   // Метод видалення продукту
        {
            var product = await _context.products.FindAsync(id);
            if (product == null)                    // Перевірка, чи існує в БД продукт, 
            {                                       // який треба видалити 
                return false;
            }
            _context.products.Remove(product);      // Видалення продукту
            await _context.SaveChangesAsync();      // Збереження змін
            return true;
        }
        public async Task<Product?> GetProduct(Guid id) // Метод отрання продукту  
        {                                               // за ідентифікатором
            var product = await _context.products.Include("Category")  // Пошук продукту в БД
                .FirstOrDefaultAsync(temp => temp.ProductID == id);  
            if (product == null)                                       // Перевірка на нуль
            {
                return null;
            }
            return product;                                      // Повернення результату
        }
        public async Task<List<Product>?> GetProducts()  // Метод отрання всіх продуктів
        {
            List<Product> products = await _context.products // Отримання колекції всіх продуктів
                .Include("Category").ToListAsync();
            if (products == null)                       // Перевірка на нуль
            {
                return null;
            }
            else
            {
                return products;                        // Повернення результату
            }
        }

        public async Task<bool> UpdateProduct(Guid id, Product product) // Метод оновлення 
        {                                                               // існуючого продукту
            if (id != product.ProductID)                    // Перевірка чи є передані 
            {                                               // ідентифікатори однаковими
                return false;
            }
            Product? existingProduct = await _context.products.FindAsync(id); // Пошук існуючого 
            if (existingProduct == null)                                      // продукту, дані
            {                                                                 // якого треба 
                return false;                                                 // оновити
            }
            List<Product>? products = await GetProducts();          // Отримання всіх продуктів
            if (product.Price <= 0)                            // Якщо в БД відсутні продукти,
            {                                                  // то дані для оновлення відсутні
                return false;
            }
            if (products != null)
            {
                foreach (Product prod in products)                  // Перевірка, чи не опиниться
                {                                                   // в базі даних два однакових 
                    if (prod.ProductName == product.ProductName &&  // продуктів після оновлення
                        prod.Price == product.Price &&
                        prod.SKU == product.SKU &&
                        prod.CategoryID == product.CategoryID)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            existingProduct.ProductName = product.ProductName;      // Оновлення даних  
            existingProduct.Price = product.Price;                  // існуючого запису таблиці
            existingProduct.SKU = product.SKU;
            existingProduct.CategoryID = product.CategoryID;

            try                                                  // Спроба зберегти зміни
            {
                await _context.SaveChangesAsync();               
                return true;
            }
            catch (DbUpdateConcurrencyException)   // Відловлювання вийняткових ситуацій 
            {
                if (!await ProductExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }
        private async Task<bool> ProductExists(Guid id)   // Метод для перевірки снування продукту
        {
            return _context.products.Any(e => e.ProductID == id);
        }
    }
}
