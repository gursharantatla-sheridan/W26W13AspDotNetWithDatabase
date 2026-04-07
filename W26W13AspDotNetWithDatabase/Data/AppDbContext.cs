using Microsoft.EntityFrameworkCore;
using W26W13AspDotNetWithDatabase.Models;

namespace W26W13AspDotNetWithDatabase.Data
{
    public class AppDbContext : DbContext
    {
        // define the connection
        // done by using the constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // define entity sets
        // using DbSet<> properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        // data seeding
        // overriding the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Electronics" },
                new Category { CategoryId = 2, CategoryName = "Clothing" },
                new Category { CategoryId = 3, CategoryName = "Books" },
                new Category { CategoryId = 4, CategoryName = "Appliances" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Laptop", Price = 1200, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Mobile", Price = 2000, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Jacket", Price = 100, CategoryId = 2 },
                new Product { ProductId = 4, Name = "Harry Potter", Price = 20, CategoryId = 3 },
                new Product { ProductId = 5, Name = "Fridge", Price = 800, CategoryId = 4 }
            );
        }
    }
}
