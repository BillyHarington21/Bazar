using Bazar.Models;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Fruits" },
                new Category { CategoryId = 2, CategoryName = "Vegetables" },
                new Category { CategoryId = 3, CategoryName = "Dairy" },
                new Category { CategoryId = 4, CategoryName = "Baked Goods" },
                new Category { CategoryId = 5, CategoryName = "Beverages" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Apple", Price = 1.20m, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Banana", Price = 0.50m, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Orange", Price = 0.80m, CategoryId = 1 },
                new Product { ProductId = 4, Name = "Broccoli", Price = 1.00m, CategoryId = 2 },
                new Product { ProductId = 5, Name = "Carrot", Price = 0.30m, CategoryId = 2 },
                new Product { ProductId = 6, Name = "Milk", Price = 1.50m, CategoryId = 3 },
                new Product { ProductId = 7, Name = "Cheese", Price = 2.50m, CategoryId = 3 },
                new Product { ProductId = 8, Name = "Bread", Price = 1.00m, CategoryId = 4 },
                new Product { ProductId = 9, Name = "Cake", Price = 3.00m, CategoryId = 4 },
                new Product { ProductId = 10, Name = "Coffee", Price = 4.00m, CategoryId = 5 },
                new Product { ProductId = 11, Name = "Tea", Price = 2.00m, CategoryId = 5 },
                new Product { ProductId = 12, Name = "Soda", Price = 1.00m, CategoryId = 5 },
                new Product { ProductId = 13, Name = "Yogurt", Price = 1.20m, CategoryId = 3 },
                new Product { ProductId = 14, Name = "Spinach", Price = 0.80m, CategoryId = 2 },
                new Product { ProductId = 15, Name = "Grapes", Price = 2.00m, CategoryId = 1 }
            );
        }
    }
}
