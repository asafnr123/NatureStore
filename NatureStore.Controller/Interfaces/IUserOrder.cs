

namespace NatureStore.Controller.Interfaces
{
    public interface IUserOrder
    {
        int OrderNumber { get; set; }
        string Prod { get; set; }
        string Quantity { get; set; }
        string OrderDate { get; set; }
        string Price { get; set; }
    }
}
