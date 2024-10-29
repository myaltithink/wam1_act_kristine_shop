using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesAndInventoryProgram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndInventoryProgram.Data
{
    internal class ShopContext : DbContext
    {

        private readonly string connectionString = "Server=localhost;User ID=root;Password=wasdwasd;Database=kristine_shop";
        
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.HasIndex(u => u.Username).IsUnique();
            });

            modelBuilder.Entity<User>().HasData
                (
                    new User() 
                    {
                        Id = 1,
                        FirstName = "Kristine",
                        LastName = "Shop",
                        Username = "kristine",
                        Password = "wasdwasd"
                    }
                );

        }
    }
}
