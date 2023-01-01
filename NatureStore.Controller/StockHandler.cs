using NatureStore.Model.Context;
using NatureStore.Model.Entitys;


namespace NatureStore.Controller
{
    public class StockHandler
    {
        private readonly NatureStoreDbContext db;
        private readonly DbReader reader = new();
        private readonly DbCreator creator = new();
        private readonly DbUpdater updater = new();

        public StockHandler()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }

        public bool CheckProductId(string prodId)
        {
            int id;
            if (int.TryParse(prodId, out id))
            {
                var query = from prod in db.Products
                            select prod.Id;

                if (query.Contains(id))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public bool CheckQuantity(string quantity)
        {
            int quant;

            if (int.TryParse(quantity, out quant))
                return true;
            else
                return false;
        }

        public bool SubmitNewStock(string prodId, string quantity)
        {
            var product = reader.GetProductById(int.Parse(prodId));
            var allstocks = reader.GetAllStockProducts();

            if (allstocks.Contains(product))
                return false;
            else
            {
                var quant = int.Parse(quantity);
                var newStock = new Stock();
                newStock.Product = product;
                newStock.Quantity = quant;
                return creator.AddNewStock(newStock);
            }
        }

        public bool ChangeQtyInStock(string prodId, string quantity)
        {
            var productInStock = reader.GetProductById(int.Parse(prodId));

            if (updater.UpdateProductQtyInStock(productInStock, int.Parse(quantity)))
                return true;
            else
                return false;
        }

        public bool RemoveStock(string prodId)
        {
            var productInStock = reader.GetProductById(int.Parse(prodId));

            return updater.RemoveStockByProduct(productInStock);
        }

    }
}
