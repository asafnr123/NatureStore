using Microsoft.EntityFrameworkCore;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
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
        private static int counter = 0;
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }    
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=(local);Initial Catalog=NatureStoreDb;User Id=anyuser;Password=Ns1213;;TrustServerCertificate=True;");
            if(counter == 0)
            {
                counter++;
                CreateDbLocally();
            }

        }

        public void CreateDbLocally()
        {
            using (var client = new NatureStoreDbContext())
            {
                client.Database.EnsureCreated();
            }
        }


    }

    
}
