using NatureStore.Controller;
using NatureStore.Model.Entitys;
using NatureStore.View.MyUserControls;
using NatureStore.View.Pages.UserCart;
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
using System.Xml;

namespace NatureStore.View.Pages.ProductsDropMenu
{
    /// <summary>
    /// Interaction logic for ProteinPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage(string productType, User user)
        {
            InitializeComponent();
            ProductType = productType;
            this.loggedInUser = user;
            AddProductsToMenu();
        }

        public string ProductType { get; set; }

        public string SelectedProduct { get; set; }

        private readonly DbReader? reader = new();

        private CartHandler cartHandler = new();

        private User loggedInUser;






        public void AddProductsToMenu()
        {
            
            if(ProductType == "Protein")
            {
                List<Product> allProtein = reader.GetAllProtein();
                this.menuSP.Children.Clear();
                allProtein.ForEach(protein =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = protein.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    nameLabel.MouseDown += AddImage_Label_Click;
                    nameLabel.MouseDown += AddDescription_Label_Click;
                    nameLabel.MouseDown += AddPrice_Label_Click;
                    nameLabel.MouseDown += SetSelectedProduct;
                    this.menuSP.Children.Add(nameLabel);
                });
            }

            else if (ProductType == "Snacks")
            {
                List<Product> allProtein = reader.GetAllSnacks();
                this.menuSP.Children.Clear();
                allProtein.ForEach(snack =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = snack.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    nameLabel.MouseDown += AddImage_Label_Click;
                    nameLabel.MouseDown += AddDescription_Label_Click;
                    nameLabel.MouseDown += AddPrice_Label_Click;
                    nameLabel.MouseDown += SetSelectedProduct;
                    this.menuSP.Children.Add(nameLabel);
                });
            }

            else if (ProductType == "Vitamins")
            {
                List<Product> allProtein = reader.GetAllVitamins();
                this.menuSP.Children.Clear();
                allProtein.ForEach(vitamin =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = vitamin.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    nameLabel.MouseDown += AddImage_Label_Click;
                    nameLabel.MouseDown += AddDescription_Label_Click;
                    nameLabel.MouseDown += AddPrice_Label_Click;
                    nameLabel.MouseDown += SetSelectedProduct;
                    this.menuSP.Children.Add(nameLabel);
                });
            }

            else if (ProductType == "Creatine")
            {
                List<Product> allProtein = reader.GetAllCreatine();
                this.menuSP.Children.Clear();
                allProtein.ForEach(creatine =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = creatine.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    nameLabel.MouseDown += AddImage_Label_Click;
                    nameLabel.MouseDown += AddDescription_Label_Click;
                    nameLabel.MouseDown += AddPrice_Label_Click;
                    nameLabel.MouseDown += SetSelectedProduct;
                    this.menuSP.Children.Add(nameLabel);
                });
            }
        }

        private void quantityUp_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(this.quantityLbl.Content.ToString());
            if(quantity < 10)
            {
            quantity++;
            this.quantityLbl.Content = quantity.ToString();
            }
        }

        private void quantityDown_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(this.quantityLbl.Content.ToString());
            if(quantity > 1)
            {
            quantity--;
            this.quantityLbl.Content = quantity.ToString();
            }
        }


        private void AddImage_Label_Click(object sender, RoutedEventArgs e)
        {            
            var myLabel = (Label)sender;
            Image finalImage = new Image();
            finalImage.Stretch = Stretch.Fill;
            finalImage.Width = 250;
            finalImage.Height = 240;

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(reader?.GetImagePathByProdName((string)myLabel.Content));
            image.EndInit();

            if(image.UriSource != null)
            {
                finalImage.Source = image;
                this.imageSP.Children.Clear();
                this.imageSP.Children.Add(finalImage);
            }
        }

        private void AddDescription_Label_Click(object sender, RoutedEventArgs e)
        {
            
            var myLabel = (Label)sender;
            var txtBlock = new TextBlock();
            txtBlock.Style = (Style)FindResource("describTxt");
            txtBlock.Text = reader?.GetDescriptionByProdName((string)myLabel.Content);
            
            this.descriptionWP.Children.Clear();
            this.descriptionWP.Children.Add(txtBlock);
        }

        private void AddPrice_Label_Click(object sender, RoutedEventArgs e)
        {
            var myLabel = (Label)sender;

            string price = reader?.GetPriceByProdName((string)myLabel.Content).ToString() + "$";

            // get price function returns 0 if null 
            if(price != "0")
                this.priceLbl.Content = price;
        }

        private void SetSelectedProduct(object sender, RoutedEventArgs e)
        {
            var label = (Label)sender;
            this.SelectedProduct = (string)label.Content;
        }

        private void addToCartBtn_Click(object sender, RoutedEventArgs e)
        {
            var productUserControl = new ProductInCart();
            productUserControl.ProdName = this.SelectedProduct;
            productUserControl.ProdQty = (string)quantityLbl.Content;
            cartHandler.AddProductToCart(productUserControl);
            MessageBox.Show("Product Added To Cart");
            quantityLbl.Content = "1";
        }
    }
}
