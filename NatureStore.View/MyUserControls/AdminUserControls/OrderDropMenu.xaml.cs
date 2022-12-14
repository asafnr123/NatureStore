using NatureStore.Controller;
using NatureStore.View.Pages.AdminHomePage;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;


namespace NatureStore.View.MyUserControls.AdminUserControls
{
    /// <summary>
    /// Interaction logic for OrderDropMenu.xaml
    /// </summary>
    public partial class OrderDropMenu : UserControl
    {
        public OrderDropMenu()
        {
            InitializeComponent();
        }

        public AdminPage adminPage { private get; set; }
        private DbReader reader = new();
        private OrderHandler pageHandler = new();
        private void allOrdersLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.ItemsSource = null;
            adminPage.myDataGrid.ItemsSource ??= reader.GetAllOrders().ToList();
            adminPage.MainAdminFrame.Visibility = Visibility.Hidden;
            adminPage.ordersWp.Visibility = Visibility.Hidden;
            adminPage.myDataGrid.Visibility = Visibility.Visible;
        }

        private void orderByUserLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new AdminOrdersPage("OrderByUser"));
            adminPage.ordersWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }

        private void orderDetailLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new AdminOrdersPage("OrderDetails"));
            adminPage.ordersWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }

        private void removeOrderLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new AdminOrdersPage("RemoveOrder"));
            adminPage.ordersWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }
    }
}
