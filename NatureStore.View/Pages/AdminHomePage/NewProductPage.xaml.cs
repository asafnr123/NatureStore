using Microsoft.Win32;
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

namespace NatureStore.View.Pages.AdminHomePage
{
    /// <summary>
    /// Interaction logic for NewProductPage.xaml
    /// </summary>
    public partial class NewProductPage : Page
    {
        public NewProductPage()
        {
            InitializeComponent();
        }

        private NewProductHandler pageHandler = new();
        private DbReader reader = new();
        private DbCreator creator = new();

        private void prodSubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!pageHandler.CheckName(prodName.Text))
                MessageBox.Show("Invalid Name");

            else if (!pageHandler.CheckCategoryId(prodCate.Text))
                MessageBox.Show("Invalid Category Id");

            else if (!pageHandler.CheckPrice(prodPrice.Text))
                MessageBox.Show("Invalid Price");

            else if (!pageHandler.CheckDescription(prodDesc.Text))
                MessageBox.Show("Invalid Description");

            else if (!pageHandler.CheckBrand(prodBrand.Text))
                MessageBox.Show("Invalid Brand");

            else if (!pageHandler.CheckImage(prodImg.Text))
                MessageBox.Show("Invalid Image");

            else
            {
                var newProd = new Product();
                var prodCategory = reader.GetCategory(int.Parse(prodCate.Text));

                newProd.Name = prodName.Text;
                newProd.Category = prodCategory;
                newProd.Price = float.Parse(prodPrice.Text);
                newProd.Description = prodDesc.Text;
                newProd.Brand = prodBrand.Text;
                newProd.Image = prodImg.Text;

                if (creator.AddNewProduct(newProd))
                    MessageBox.Show("Product Added Successfully");
            }


        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            prodName.Text = "";
            prodCate.Text = "";
            prodPrice.Text = "";
            prodDesc.Text = "";
            prodBrand.Text = "";
            prodImg.Text = "";
        }
    }
}
