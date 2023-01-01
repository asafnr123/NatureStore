using NatureStore.Model.Entitys;


namespace NatureStore.Model.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; } 
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public float OrderValue { get; set; }

        public OrderDetail() { }

        public OrderDetail(int quantity, float orderValue)
        {
            Quantity = quantity;
            OrderValue = orderValue;
        }

    }
}
