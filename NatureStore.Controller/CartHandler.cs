using NatureStore.Controller.Interfaces;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class CartHandler
    {
        public static List<Product> ProductsToCart = new();
        private readonly DbReader reader = new();
        public static List<string> ProdQuantity { get; set; } = new List<string>();


        public List<Product> GetProductsInCart
        {
            get { return ProductsToCart; }
        }

        public List<string> GetAllQuantity
        {
            get { return ProdQuantity; }
        }

        public bool RemoveProductFromCart(Product prod)
        {
            // returns true if object was removed 
            return ProductsToCart.Remove(prod);
        } 

        public void AddProductToCart(string prodName)
        {
            var product = reader.GetProduct(prodName);
            if(product != null)
                ProductsToCart.Add(product);
        }

        public void AddProductQuantity(string quantity)
        {
            if (quantity != null)
                ProdQuantity.Add(quantity);

        }



    }
}

