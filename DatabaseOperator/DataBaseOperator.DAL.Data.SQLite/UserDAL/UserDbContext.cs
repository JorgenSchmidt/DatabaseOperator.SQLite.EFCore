using Microsoft.EntityFrameworkCore;

using DataBaseOperator.Domain.Core;

namespace DataBaseOperator.DAL.Data.SQLite.UserDAL
{
    public class UserDbContext : DbContext
    {

        public UserDbContext ()
        {
            Database.EnsureCreated();
        } 
        
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=user_database.db");
        }

    }
}
