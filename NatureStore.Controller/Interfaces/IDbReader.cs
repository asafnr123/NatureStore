using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;


namespace NatureStore.Controller.Interfaces
{
    public interface IDbReader
    {
        List<User> GetAllUsers();
        IEnumerable<object> GetAllOrders();
        IEnumerable<object> GetAllProducts();
        IEnumerable<object> GetAllStocks();
        List<Category> GetAllCategorys();
        List<Product> GetAllProtein();
        List<Product> GetAllVitamins();
        List<Product> GetAllCreatine();
        List<Product> GetAllSnacks();
        User GetUser(string username, string password);
        Product GetProductByName(string prodName);
        List<UserExistOrder> GetUserOrders(User user);
        string GetDescriptionByProdName(string prodName);
        string GetImagePathByProdName(string prodName);
        bool CheckIfUserExistInDb(string username, string password);
        bool CheckUserTypeByUsername(string username);


    }
}
