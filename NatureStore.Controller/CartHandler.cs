using NatureStore.Controller.Interfaces;
using NatureStore.Model.Entities;
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
        private readonly DbReader reader = new();
        private readonly DbCreator adder = new();


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


        public float GetTotalValue()
        {
            float totalValue = 0;
            ProductsInCart.ForEach(prod =>
            {
                var prodPrice = reader.GetPriceByProdName(prod.ProdName);
                totalValue += prodPrice * int.Parse(prod.ProdQty);
            });

            return totalValue;
        }


        public bool ConfirmOrder(User user)
        {
            float totalValue = GetTotalValue();

            if (user == null || totalValue == 0)
                return false;

            bool success = false;
            var order = new Order(totalValue);
            order.User = user;

            ProductsInCart.ForEach(prod =>
            {
                var product = reader.GetProduct(prod.ProdName);
                var orderD = new OrderDetail(int.Parse(prod.ProdQty), product.Price);
                orderD.Product = product;
                orderD.Order = order;
                if (adder.AddNewOrderDetail(orderD))
                    success = true;
                else
                    success = false;
            });

            if(success == true)
                adder.AddNewOrder(order);

            return success;

        }
        



    }
}

