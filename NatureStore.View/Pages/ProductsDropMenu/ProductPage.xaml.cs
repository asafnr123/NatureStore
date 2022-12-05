using NatureStore.Controller;
using NatureStore.Model.Entitys;
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
        public ProductPage(string productType)
        {
            InitializeComponent();
            ProductType = productType;
            AddProductsToMenu();
        }


        public string ProductType { get; set; }
        private readonly DbReader reader = new();

        public void AddProductsToMenu()
        {
            Label newLabel = new Label();
            
            if(ProductType == "Protein")
            {
                List<Product> allProtein = reader.GetAllProtein();
                this.menuSP.Children.Clear();
                allProtein.ForEach(protein =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = protein.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    nameLabel.MouseDown += LabelButton_Click;
                    this.menuSP.Children.Add(nameLabel);
                });
            }

            else if (ProductType == "Snacks")
            {
                List<Product> allSnacks = reader.GetAllSnacks();
                this.menuSP.Children.Clear();
                allSnacks.ForEach(snack =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = snack.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    this.menuSP.Children.Add(nameLabel);
                });
            }

            else if (ProductType == "Vitamins")
            {
                List<Product> allVitamins = reader.GetAllVitamins();
                this.menuSP.Children.Clear();
                allVitamins.ForEach(vitamin =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = vitamin.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    this.menuSP.Children.Add(nameLabel);
                });
            }

            else if (ProductType == "Creatine")
            {
                List<Product> allCreatine = reader.GetAllCreatine();
                this.menuSP.Children.Clear();
                allCreatine.ForEach(creatine =>
                {
                    var nameLabel = new Label();
                    nameLabel.Content = creatine.Name;
                    nameLabel.Style = (Style)FindResource("productLabel");
                    this.menuSP.Children.Add(nameLabel);
                });
            }
        }

        private void quantityUp_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(this.quantityBtn.Content.ToString());
            if(quantity < 10)
            {
            quantity++;
            this.quantityBtn.Content = quantity.ToString();
            }
        }

        private void quantityDown_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(this.quantityBtn.Content.ToString());
            if(quantity > 1)
            {
            quantity--;
            this.quantityBtn.Content = quantity.ToString();
            }
        }


        private void LabelButton_Click(object sender, RoutedEventArgs e)
        {

            // Stretch="Fill" Width="230" Height="220"

            var myLabel = ((Label)sender);
            Image finalImage = new Image();
            finalImage.Stretch = Stretch.Fill;
            finalImage.Width = 230;
            finalImage.Height = 220;

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            string check = reader.GetImagePathByProdName((string)myLabel.Content);
            image.UriSource = new Uri(reader.GetImagePathByProdName((string)myLabel.Content));
            image.EndInit();

            if(image.UriSource != null)
            {
                finalImage.Source = image;
                this.imageSP.Children.Add(finalImage);
            }



            if (ProductType == "Protein")
            {

            }

            else if (ProductType == "Snacks")
            {

            }

            else if (ProductType == "Vitamins")
            {

            }

            else if (ProductType == "Creatine")
            {

            }
        }




    }
}
