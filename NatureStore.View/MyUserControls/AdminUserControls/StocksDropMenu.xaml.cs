using NatureStore.Controller;
using NatureStore.View.Pages.AdminHomePage;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace NatureStore.View.MyUserControls.AdminUserControls
{
    /// <summary>
    /// Interaction logic for StocksDropMenu.xaml
    /// </summary>
    public partial class StocksDropMenu : UserControl
    {
        public StocksDropMenu()
        {
            InitializeComponent();
        }

        public AdminPage adminPage { private get; set; }
        private readonly DbReader reader = new();

        private void allStocks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.ItemsSource = null;
            adminPage.myDataGrid.ItemsSource ??= reader.GetAllStocks();
            adminPage.MainAdminFrame.Visibility = Visibility.Hidden;
            adminPage.stocksWP.Visibility = Visibility.Hidden;
            adminPage.myDataGrid.Visibility = Visibility.Visible;
        }

        private void newStock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new AddNewStockPage());
            adminPage.stocksWP.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }

        private void editStock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new EditStockPage());
            adminPage.stocksWP.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }
    }
}
