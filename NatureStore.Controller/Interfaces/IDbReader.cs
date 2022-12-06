﻿using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller.Interfaces
{
    public interface IDbReader
    {
        List<User> GetAllUsers();
        List<Order> GetAllOrders();
        List<Product> GetAllProducts();
        List<Stock> GetAllStocks();
        List<Category> GetAllCategorys();
        List<Product> GetAllProtein();
        List<Product> GetAllVitamins();
        List<Product> GetAllCreatine();
        List<Product> GetAllSnacks();
        User GetUser(string username, string password);
        string GetDescriptionByProdName(string prodName);
        string GetImagePathByProdName(string prodName);
        bool CheckIfUserExistInDb(string username, string password);
        bool CheckUserTypeByUsername(string username);


    }
}
