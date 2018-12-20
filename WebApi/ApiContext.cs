using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(o => o.HasData(
                new Product { Id = 1, Name = "Item 1" },
                new Product { Id = 2, Name = "Item 2" }
            ));
        }
    }
}