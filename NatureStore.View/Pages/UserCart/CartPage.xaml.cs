using NatureStore.Controller;
using NatureStore.Controller.Interfaces;
using NatureStore.Model.Entitys;
using NatureStore.View.MyUserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NatureStore.View.Pages.UserCart
{
    /// <summary>
    /// Interaction logic for CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        public CartPage(List<IProductToCart> userProduts)
        {
            InitializeComponent();
            this.UserProducts = userProduts;
            CheckIfCartEmpty(UserProducts);
           
        }

        CartHandler cartHandler = new();
        public List<IProductToCart> UserProducts { get; set; }  

        public void CheckIfCartEmpty(List<IProductToCart> produts)
        {
            if (produts == null || produts.Count == 0)
            {
                var emptyLbl = new Label();
                emptyLbl.Content = "Cart Is Empty";
                emptyLbl.Style = (Style)FindResource("labels");
                emptyLbl.HorizontalAlignment = HorizontalAlignment.Center;
                emptyLbl.VerticalAlignment= VerticalAlignment.Center;
                this.cartSP.Children.Add(emptyLbl);
            }
            else
            {
                SetProductsToCart(produts);
            }
            
        }

        public void SetProductsToCart(List<IProductToCart> produts)
        {
            cartSP.Children.Clear();
            trashSP.Children.Clear();

            produts.ForEach(prod =>
            {
                var prodInCart = new ProductInCart();
                prodInCart.ProdName = prod.ProdName;
                prodInCart.ProdQty = prod.ProdQty;

                var deleteIcon = new Path();
                deleteIcon.Style = (Style)FindResource("deleteProdIcon");
                deleteIcon.Tag = prod;
                deleteIcon.MouseDown += DeleteProdFromCart;

                this.cartSP.Children.Add(prodInCart);
                this.trashSP.Children.Add(deleteIcon);
            });


        }


        private void DeleteProdFromCart(object sender, RoutedEventArgs e)
        {
            var myProd = ((Path)sender).Tag;
            cartHandler.RemoveProductFromCart((IProductToCart)myProd);
            SetProductsToCart(UserProducts);
        }
    }
}
