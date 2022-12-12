using Microsoft.EntityFrameworkCore;
using NatureStore.Controller.Interfaces;
using NatureStore.Model.Context;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class DbCreator : IDbCreator
    {
        private readonly NatureStoreDbContext db;


        public DbCreator()
        {
            this.db = DbConnector.GetInstance().GetDb();
            DbReader reader = new();
        }

        public bool AddNewCategory(Category category)
        {
            if(category != null)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }


        public bool AddNewOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
      
        

        public bool AddNewProduct(Product product)
        {
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
