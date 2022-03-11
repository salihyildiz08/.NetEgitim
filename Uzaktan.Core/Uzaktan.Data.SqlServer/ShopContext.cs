using Microsoft.EntityFrameworkCore;
using Uzaktan.Core.Domain.Entities;

namespace Uzaktan.Data.SqlServer
{
    public class ShopContext:DbContext
    {
        public ShopContext()
        {
            Database.EnsureCreated(); // Veritabanı yoksa oluştur.
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALIH\\SQLEXPRESS;Database=UzaktanShop;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
