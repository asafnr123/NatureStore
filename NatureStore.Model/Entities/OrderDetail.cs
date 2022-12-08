using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; } 
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public float OrderValue { get; set; }

        //public OrderDetail(Order order, Product product, int quantity, float orderValue)
        //{
        //    Order = order;
        //    Product = product;
        //    Quantity = quantity;
        //    OrderValue = orderValue;
        //}
    }
}
