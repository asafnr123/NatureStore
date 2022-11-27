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
    public class DbReader : IDbReader
    {

        private readonly NatureStoreDbContext db;

        public DbReader()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }


        public bool CheckIfUserExistInDb(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user == null) return false;
            else return true;
        }

        public List<Category> GetAllCategorys()
        {
            return (from cate in db.Categories
                   select cate).ToList();
        }

        public List<Order> GetAllOrders()
        {
            return (from order in db.Orders
                    select order).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return (from prod in db.Products
                    select prod).ToList();
        }

        public List<Stock> GetAllStocks()
        {
            return (from stock in db.Stocks
                    select stock).ToList();
        }

        public List<User> GetAllUsers()
        {
            return (from user in db.Users
                    select user).ToList();
        }
    }
}
