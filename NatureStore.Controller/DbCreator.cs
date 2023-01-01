using NatureStore.Controller.Interfaces;
using NatureStore.Model.Context;
using NatureStore.Model.Entities;
using NatureStore.Model.Entitys;


namespace NatureStore.Controller
{
    public class DbCreator : IDbCreator
    {
        private readonly NatureStoreDbContext db;


        public DbCreator()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }

        public bool AddNewCategory(Category category)
        {
            if(category != null)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }


        public bool AddNewOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
      
        

        public bool AddNewProduct(Product product)
        {
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool AddNewStock(Stock stock)
        {
            if (stock != null)
            {
                db.Stocks.Add(stock);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
