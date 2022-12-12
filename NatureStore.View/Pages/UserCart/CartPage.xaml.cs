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
        public CartPage(List<IProductToCart> userProduts, User user)
        {
            InitializeComponent();
            this.UserProducts = userProduts;
            this.loggedInUser = user;
            CheckIfCartEmpty(UserProducts);
           
        }

        CartHandler cartHandler = new();
        public List<IProductToCart> UserProducts { get; set; }
        private User loggedInUser;

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
                totalValueLbl.Content = "0.00$";
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

            if (produts.Count > 0)
            {
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
                    this.totalValueLbl.Content = String.Format("{0:0.00}", cartHandler.GetTotalValue())  + "$";

                });
            }
            else
                totalValueLbl.Content = "    0";

        }


        private void DeleteProdFromCart(object sender, RoutedEventArgs e)
        {
            var myProd = ((Path)sender).Tag;
            cartHandler.RemoveProductFromCart((IProductToCart)myProd);
            SetProductsToCart(UserProducts);
        }

        private void confirmOrderBtn_Click(object sender, RoutedEventArgs e)
        {

            if (cartHandler.ConfirmOrder(loggedInUser))
            {
                MessageBox.Show("Thank You, You'r Order Has Been Accepted");
                cartSP.Children.Clear();
                trashSP.Children.Clear();
                cartHandler.ClearProductsInCart();
                this.totalValueLbl.Content = String.Format("{0:0.00}", cartHandler.GetTotalValue()) + "$";
            }

            else
                MessageBox.Show("Sorry, Something Went Wrong");
        }
    }
}
