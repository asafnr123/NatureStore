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
        public CartPage(List<Product> userProduts)
        {
            InitializeComponent();
            CheckIfCartEmpty(userProduts);
           
        }

        CartHandler cartHandler = new();

        public void CheckIfCartEmpty(List<Product> produts)
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

        public void SetProductsToCart(List<Product> produts)
        {
            this.cartSP.Children.Clear();
            this.QtySP.Children.Clear();

            
            

            produts.ForEach(prod =>
            {
                var nameLabel = new Label();

                nameLabel.Content = prod.Name;

                nameLabel.Style = (Style)FindResource("productLabel");
                this.cartSP.Children.Add(nameLabel);
            });


            cartHandler.GetAllQuantity.ForEach(q =>
            {
                var qtyLabel = new Label();

                qtyLabel.Content = q;
                qtyLabel.Style = (Style)FindResource("labels");
                qtyLabel.Padding = new Thickness(20, 5, 5, 5);

                this.QtySP.Children.Add(qtyLabel);
            });
            
            
        }
    }
}
