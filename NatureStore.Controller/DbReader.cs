using NatureStore.Controller.Interfaces;
using NatureStore.Model;
using NatureStore.Model.Context;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        // return true if user is admin, return false if regular user or null
        public bool CheckUserTypeByUsername(string username)
        {
            var user = db.Users.FirstOrDefault(u => u.UserName == username);

            if (user != null)
            {
                if (user.UserType == UserType.Admin)
                    return true;
                else
                    return false;
            }
            else
                return false;
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

        public List<Product> GetAllProtein()
        {
            return (from prod in db.Products
                        join cate in db.Categories
                        on prod.Category equals cate
                        where prod.Category.Id == 1
                        select new Product
                        {
                            Name = prod.Name,
                            Category = cate,
                            Brand = prod.Brand,
                            Description = prod.Description,
                            Price = prod.Price
                        }).ToList();
        }

        public List<Product> GetAllVitamins()
        {
            return (from prod in db.Products
                    join cate in db.Categories
                    on prod.Category equals cate
                    where prod.Category.Id == 3
                    select new Product
                    {
                        Name = prod.Name,
                        Category = cate,
                        Brand = prod.Brand,
                        Description = prod.Description,
                        Price = prod.Price
                    }).ToList();
        }

        public List<Product> GetAllCreatine()
        {
            return (from prod in db.Products
                    join cate in db.Categories
                    on prod.Category equals cate
                    where prod.Category.Id == 4
                    select new Product
                    {
                        Name = prod.Name,
                        Category = cate,
                        Brand = prod.Brand,
                        Description = prod.Description,
                        Price = prod.Price
                    }).ToList();
        }

        public List<Product> GetAllSnacks()
        {
            return (from prod in db.Products
                    join cate in db.Categories
                    on prod.Category equals cate
                    where prod.Category.Id == 2
                    select new Product
                    {
                        Name = prod.Name,
                        Category = cate,
                        Brand = prod.Brand,
                        Description = prod.Description,
                        Price = prod.Price
                    }).ToList();
        }

        public string GetImagePathByProdName(string prodName)
        {
            var product = db.Products.FirstOrDefault(prod => prod.Name == prodName);
            if (product != null)
            {
                return "";
            }
            else
                return null;
        }

       
    }
}
