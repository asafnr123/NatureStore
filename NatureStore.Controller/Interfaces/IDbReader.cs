using NatureStore.Model.Entities;
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
        bool CheckIfUserExistInDb(string username, string password);
        bool CheckUserTypeByUsername(string username);


    }
}
