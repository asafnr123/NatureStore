using NatureStore.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class UserExistOrder : IUserOrder
    {
        public string Prod { get ; set; }
        public string Quantity { get; set; }
        public string OrderDate { get; set; }
        public string Price { get; set; }
        public int OrderNumber { get; set; }
    }
}
