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

    }
}
