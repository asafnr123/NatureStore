using NatureStore.Controller.Interfaces;
using NatureStore.Model;
using NatureStore.Model.Context;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;


namespace NatureStore.Controller
{
    public class DbReader : IDbReader
    {

        private readonly NatureStoreDbContext db;

        public DbReader()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }

        // return true if user is admin, return false if regular user or null
        public bool CheckUserTypeByUsername(string username)
        {
            var user = db.Users.FirstOrDefault(u => u.UserName == username);

            if (user != null)
            {
                if (user.UserType == UserType.Admin)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }


        public bool CheckIfUserExistInDb(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user == null) return false;
            else return true;
        }

        public List<Category> GetAllCategorys()
        {
            var query = (from cate in db.Categories
                   select cate).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public IEnumerable<object> GetAllOrders()
        {
            var query = (from order in db.Orders
                         join user in db.Users on order.User equals user
                         orderby order.Id
                         select new
                         {
                             OrderId = order.Id,
                             Username = user.UserName,
                             UserId = user.Id,
                             Address = user.Address,
                             City = user.City,
                             Country = user.Country,
                             OrderDate = order.OrderDate
                         }).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public IEnumerable<object> GetAllProducts()
        {
            var query = (from prod in db.Products
                         join cate in db.Categories on prod.Category equals cate into prodCateTable
                         select new
                         {
                             Id = prod.Id,
                             Name = prod.Name,
                             CategoryId = prod.Category.Id,
                             Price = prod.Price,
                             Description = prod.Description,
                             Brand = prod.Brand,
                             Image = prod.Image,
                         });

            if (query != null)
                return query;
            else
                return null;
        }

        public IEnumerable<object> GetAllStocks()
        {
            var query = (from stock in db.Stocks
                        join prod in db.Products on stock.Product equals prod
                        select new
                        {
                            Id = stock.Id,
                            ProductName = prod.Name,
                            ProductId = prod.Id,
                            Quantity = stock.Quantity
                        }).ToList();

            if (query != null)
                return query;
            else
                return null;
                    
        }

        public IEnumerable<object> GetAllStockProducts()
        {
            var query = from stock in db.Stocks
                        select stock.Product;

            if (query != null)
                return query;
            else
                return null;
        }

        public List<User> GetAllUsers()
        {
            var query = (from user in db.Users
                    select user).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public List<Product> GetAllProtein()
        {
            var query =  (from prod in db.Products
                        join cate in db.Categories
                        on prod.Category equals cate
                        where prod.Category.Id == 1
                        select new Product
                        {
                            Name = prod.Name,
                            Category = cate,
                            Brand = prod.Brand,
                            Description = prod.Description,
                            Price = prod.Price
                        }).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public List<Product> GetAllVitamins()
        {
            var query = (from prod in db.Products
                    join cate in db.Categories
                    on prod.Category equals cate
                    where prod.Category.Id == 3
                    select new Product
                    {
                        Name = prod.Name,
                        Category = cate,
                        Brand = prod.Brand,
                        Description = prod.Description,
                        Price = prod.Price
                    }).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public List<Product> GetAllCreatine()
        {
            var query = (from prod in db.Products
                    join cate in db.Categories
                    on prod.Category equals cate
                    where prod.Category.Id == 4
                    select new Product
                    {
                        Name = prod.Name,
                        Category = cate,
                        Brand = prod.Brand,
                        Description = prod.Description,
                        Price = prod.Price
                    }).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public List<Product> GetAllSnacks()
        {
            var query = (from prod in db.Products
                    join cate in db.Categories
                    on prod.Category equals cate
                    where prod.Category.Id == 2
                    select new Product
                    {
                        Name = prod.Name,
                        Category = cate,
                        Brand = prod.Brand,
                        Description = prod.Description,
                        Price = prod.Price
                    }).ToList();
            if (query != null)
                return query;
            else
                return null;
        }

        public string GetImagePathByProdName(string prodName)
        {
            var product = db.Products.FirstOrDefault(prod => prod.Name == prodName);

            if (product != null)
                return product.Image;
            else
                return null;
        }

        public string GetDescriptionByProdName(string prodName)
        {
            var product = db.Products.FirstOrDefault(prod => prod.Name == prodName);
            if (product != null)
                return product.Description;
            else
                return null;
        }

        public float GetPriceByProdName(string prodName)
        {
            var product = db.Products.FirstOrDefault(prod => prod.Name == prodName);
            if (product != null)
                return product.Price;
            else
                return 0;
        }

        public User GetUser(string username, string password)
        {
            return db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

        public User GetUserById(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public Category GetCategory(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public Product GetProductByName(string prodName)
        {
            return db.Products.FirstOrDefault(p => p.Name == prodName);
        }

        public Product GetProductById(int id)
        {
            return db.Products.FirstOrDefault(p => p.Id == id);
            
        }



        public List<UserExistOrder> GetUserOrders(User user)
        {
            var result = (from order in db.Orders
                          join orderD in db.OrderDetails on order equals orderD.Order
                          where order.User == user
                          orderby order.OrderDate descending
                          select new UserExistOrder
                          {
                              OrderNumber = order.Id,
                              Prod = orderD.Product.Name,
                              Quantity = orderD.Quantity.ToString(),
                              OrderDate = order.OrderDate.ToString("dd/MM/yyyy"),
                              Price = String.Format("{0:0.00}", orderD.OrderValue)

                          }).Take(12).ToList();

            if (result != null)
                return result;
            else
                return null;
        }

    }
}
