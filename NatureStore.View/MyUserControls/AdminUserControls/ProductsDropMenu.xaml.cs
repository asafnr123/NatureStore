using NatureStore.Controller;
using NatureStore.View.Pages.AdminHomePage;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;


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
            adminPage.myDataGrid.ItemsSource = null;
            adminPage.myDataGrid.ItemsSource ??= reader.GetAllProducts().ToList();
            adminPage.MainAdminFrame.Visibility = Visibility.Collapsed;
            adminPage.productsWp.Visibility = Visibility.Hidden;
            adminPage.myDataGrid.Visibility = Visibility.Visible;
        }

        private void newProdLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new NewProductPage());
            adminPage.productsWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }

        private void editProdLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new EditProductPage());
            adminPage.productsWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }
    }
}
