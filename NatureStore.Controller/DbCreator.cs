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

        public bool AddNewOrder(Order order)
        {
            try
            {
                if (order != null)
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch( DbUpdateException)
            {
                if (db.Orders.FirstOrDefault(o => o.Id == order.Id) != null)
                    return true;
                else
                    return false;
            }
            
            
        }

        public bool AddNewOrderDetail(OrderDetail orderDetail)
        {
            try
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
            catch (DbUpdateException)
            {
                if (db.Orders.FirstOrDefault(o => o.Id == orderDetail.Id) != null)
                    return true;
                else
                    return false;
            }
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
