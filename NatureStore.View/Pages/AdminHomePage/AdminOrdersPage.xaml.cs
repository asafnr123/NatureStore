using NatureStore.Controller;
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
    /// Interaction logic for AdminOrdersPage.xaml
    /// </summary>
    public partial class AdminOrdersPage : Page
    {
        public AdminOrdersPage()
        {
            InitializeComponent();
        }

        DbReader reader = new();
        OrderHandler pageHandler = new();

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;

            if (int.TryParse(userIdTxt.Text, out id))
            {
                if (pageHandler.CheckIfUserExist(id))
                {
                    ordersDg.ItemsSource = null;
                    ordersDg.ItemsSource = pageHandler.GetOrderByUser(id);
                    ordersDg.Visibility = Visibility.Visible;
                }
                else
                    MessageBox.Show("Invalid Id");
            }
            else
                MessageBox.Show("Invalid Id");
        }
    }
}
