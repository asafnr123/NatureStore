using NatureStore.Model.Entitys;


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
