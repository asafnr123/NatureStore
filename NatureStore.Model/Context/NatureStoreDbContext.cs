using Microsoft.EntityFrameworkCore;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Context
{
    public class NatureStoreDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }    
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=2a06:c701:4346:6b00:f924:8c06:294:2872,1433;Initial Catalog=NatureStoreDb;User ID=anyuser;Password=Ns1213;TrustServerCertificate=True;");
        }
        
    }

    
}
