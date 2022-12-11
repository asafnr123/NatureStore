using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller.Interfaces
{
    public interface IDbCreator
    {
        bool AddNewCategory(Category category);
        bool AddNewProduct(Product product);
        bool AddNewOrder(Order order);
        bool AddNewOrderDetail(OrderDetail orderDetail);    


    }
}
