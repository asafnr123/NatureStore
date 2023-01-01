using NatureStore.Controller.Interfaces;
using NatureStore.Model.Context;


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
                         orderby order.Id, user.Id
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

        public bool CheckIfOrderExist(int orderId)
        {
            var order = db.Orders.FirstOrDefault(o => o.Id == orderId);

            if (order != null)
                return true;
            else
                return false;
        }

        public IEnumerable<object> GetOrderDetails(int orderId)
        {
            return (from order in db.Orders
                    join details in db.OrderDetails on order equals details.Order
                    join user in db.Users on order.User equals user
                    where order.Id == orderId
                    orderby order.Id
                    select new
                    {
                        OrderId = order.Id,
                        ProductName = details.Product.Name,
                        UserId = user.Id,
                        Quantity = details.Quantity,
                        OrderDate = order.OrderDate,
                        OrderValue = details.OrderValue,
                        TotalValue = order.TotalValue,
                    }).ToList();
        }

        public bool DeleteOrder(int orderId)
        {
            var order = db.Orders.FirstOrDefault(o => o.Id == orderId);

            if (order != null)
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
        



       
    }
}
