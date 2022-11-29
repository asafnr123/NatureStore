using NatureStore.Controller.Interfaces;
using NatureStore.Model.Context;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class DbGetter : IDbGetter
    {
        private readonly NatureStoreDbContext db = DbConnector.GetInstance().GetDb();

        public List<Product> GetAllProducts()
        {
            return (from p in db.Products
                    select p).ToList();
        }

        public List<User> GetAllUsers()
        {
            return (from u in db.Users
                    select u).ToList();
        }

       
    }
}
