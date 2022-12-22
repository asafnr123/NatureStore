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
    public class OrderHandler : IOrderHandler
    {

        private readonly NatureStoreDbContext db;

        public OrderHandler()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }


        public IEnumerable<object> GetOrderByUser(int userId)
        {
            return (from user in db.Users
                         join order in db.Orders on user equals order.User
                         where user.Id == userId
                         orderby order.Id
                         select new
                         {
                             orderId = order.Id,
                             Username = user.UserName,
                             UserId = user.Id,
                             UserAddress = user.Address,
                             UserCountry = user.Country,
                             UserCity = user.City,
                             OrderDate = order.OrderDate,
                             TotalValue = order.TotalValue
                         }).ToList();         
        }

        public bool CheckIfUserExist(int userId)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userId);

            if (user != null)
                return true;
            else
                return false;
        }

        public IEnumerable<object> GetOrderDetails(int orderId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }
        public bool EditOrder(int orderId)
        {
            throw new NotImplementedException();
        }



       
    }
}
