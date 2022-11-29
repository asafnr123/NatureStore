using NatureStore.Model.Entitys;


namespace NatureStore.Controller.Interfaces
{
    public interface IDbGetter
    {
        List<User> GetAllUsers();

        List<Product> GetAllProducts();


    }
}
