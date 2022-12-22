using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller.Interfaces
{
    public interface IOrderHandler
    {
        IEnumerable<object> GetOrderByUser(int userId);
        IEnumerable<object> GetOrderDetails(int orderId);
        bool DeleteOrder(int orderId);

    }
}
