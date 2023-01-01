using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;


namespace NatureStore.Controller.Interfaces
{
    public interface IDbCreator
    {
        bool AddNewCategory(Category category);
        bool AddNewProduct(Product product);
        bool AddNewOrderDetail(OrderDetail orderDetail);    


    }
}
