using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RON.WebAPI.Models;

namespace RON.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("RONDatabase"));

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Inventory> inventory { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<SaleProduct> saleproducts { get; set; }

    }
}
