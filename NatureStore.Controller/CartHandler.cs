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
        public static List<IProductToCart> ProductsInCart = new();


        public List<IProductToCart> GetProductsInCart
        {
            get { return ProductsInCart; }
        }


        public void AddProductToCart(IProductToCart prod)
        {
            if (prod != null)
                ProductsInCart.Add(prod);
        }

        public void RemoveProductFromCart(IProductToCart prod)
        {
            ProductsInCart.Remove(prod);
        }



    }
}

