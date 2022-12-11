using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalValue { get; set; }


        public Order(float totalValue)
        {
            OrderDate = DateTime.Now;
            TotalValue = totalValue;
        }


    }
}
