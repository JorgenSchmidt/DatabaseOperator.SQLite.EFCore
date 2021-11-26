using Microsoft.EntityFrameworkCore;

using DataBaseOperator.Domain.Core;

namespace DataBaseOperator.DAL.Data.SQLite.ProductDAL
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=product_database.db");
        }

    }
}
