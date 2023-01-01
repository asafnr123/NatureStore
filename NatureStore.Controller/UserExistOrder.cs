using NatureStore.Controller.Interfaces;

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
