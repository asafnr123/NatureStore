using NatureStore.Controller;
using NatureStore.View.Pages.AdminHomePage;
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

namespace NatureStore.View.MyUserControls.AdminUserControls
{
    /// <summary>
    /// Interaction logic for ProductsDropMenu.xaml
    /// </summary>
    public partial class ProductsDropMenu : UserControl
    {
        public ProductsDropMenu()
        {
            InitializeComponent();
        }


        public AdminPage adminPage { private get; set; }
        private readonly DbReader reader = new();

        private void allProdLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.ItemsSource ??= reader.GetAllProducts().ToList();
            adminPage.myDataGrid.Visibility = Visibility.Visible;
            adminPage.MainAdminFrame.Visibility = Visibility.Collapsed;
            adminPage.productsWp.Visibility = Visibility.Hidden;
        }

        private void newProdLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new NewProductPage());
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
            adminPage.productsWp.Visibility = Visibility.Hidden;
        }
    }
}
