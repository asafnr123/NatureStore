using NatureStore.Controller.Interfaces;
using NatureStore.Model.Context;
using NatureStore.Model.Entitys;


namespace NatureStore.Controller
{
    public class DbUpdater : IDbUpdater
    {
        private readonly NatureStoreDbContext db;
        private readonly DbReader reader = new();

        public DbUpdater()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }

        public bool UpdateProdBrand(int id, string brand)
        {
            var prod = reader.GetProductById(id);
            if (prod != null)
            {
                prod.Brand = brand;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool UpdateProdCategory(int id, int cateId)
        {
            var prod = reader.GetProductById(id);
            var cate = reader.GetCategory(cateId);
            if (prod != null && cate != null)
            {
                prod.Category = cate;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool UpdateProdDesc(int id, string description)
        {
            var prod = reader.GetProductById(id);
            if (prod != null)
            {
                prod.Description = description;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool UpdateProdImg(int id, string newImg)
        {
            var prod = reader.GetProductById(id);
            if (prod != null)
            {
                prod.Image = newImg;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateProdName(int id, string newName)
        {
            var prod = reader.GetProductById(id);
            if (prod != null)
            {
                prod.Name = newName;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateProdPrice(int id, string priceStr)
        {
            float price = 0;

            if (float.TryParse(priceStr, out price))
            {
                var prod = reader.GetProductById(id);
                if (prod != null)
                {
                    prod.Price = price;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool RemoveProduct(int id)
        {
            var prod = db.Products.FirstOrDefault(prod => prod.Id == id);
            if (prod != null)
            {
                db.Products.Remove(prod);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool RemoveUser(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool RemoveCategory(int id)
        {
            var cate = db.Categories.FirstOrDefault(c => c.Id == id);
            if (cate != null)
            {
                db.Categories.Remove(cate);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }


        public bool UpdateProductQtyInStock(Product prod, int newQty)
        {
            var stock = db.Stocks.FirstOrDefault(s => s.Product == prod);

            if (stock != null)
            {
                stock.Quantity = newQty;
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool RemoveStockByProduct(Product prod)
        {
            var stock = db.Stocks.FirstOrDefault(s => s.Product == prod);
            if (stock != null)
            {
                db.Stocks.Remove(stock);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }







    }
}
