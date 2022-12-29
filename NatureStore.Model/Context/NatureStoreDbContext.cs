using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
using NatureStore.Model.Group_Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Context
{
    public class NatureStoreDbContext : DbContext
    {
        private static bool dbCreatedCheck = false;
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }    
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(local);Database=NatureStoreDb;Trusted_Connection=True;TrustServerCertificate=True;");
            if(dbCreatedCheck == false)
            {
                using(var context = new NatureStoreDbContext())
                {
                    dbCreatedCheck = true;
                    context.Database.GetAppliedMigrations();
                    context.Database.EnsureCreated();
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryEntityConfiguration().Configure(modelBuilder.Entity<Category>());
            new ProductEntityConfiguration().Configure(modelBuilder.Entity<Product>());
            new UsersEntityConfiguration().Configure(modelBuilder.Entity<User>());
        }




    }

    
}
