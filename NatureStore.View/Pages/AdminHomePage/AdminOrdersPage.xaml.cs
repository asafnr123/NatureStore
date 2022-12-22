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
        public AdminOrdersPage(string pageOption)
        {
            InitializeComponent();
            this.PageOption = pageOption;
            if (pageOption == "OrderByUser")
                IdLbl.Content = "User Id :";
            else if (pageOption == "OrderDetails")
            {
                IdLbl.Content = "Order Id :";
                IdTxt.Margin = new Thickness(-81, 40, 0, 0);
            }
            else if (pageOption == "RemoveOrder")
            {
                IdLbl.Content = "Order Id :";
                IdTxt.Margin = new Thickness(-81, 40, 0, 0);
            }

        }

        DbReader reader = new();
        OrderHandler pageHandler = new();
        public string PageOption { get; set; }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;

            if (PageOption == "OrderByUser")
            {
                if (int.TryParse(IdTxt.Text, out id))
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

            else if(PageOption == "OrderDetails")
            {
                if (int.TryParse(IdTxt.Text, out id))
                {
                    if (pageHandler.CheckIfOrderExist(id))
                    {
                        ordersDg.ItemsSource = null;
                        ordersDg.ItemsSource = pageHandler.GetOrderDetails(id);
                        ordersDg.Visibility = Visibility.Visible;
                    }
                }
            }

            else if (PageOption == "RemoveOrder")
            {

                if (int.TryParse(IdTxt.Text, out id))
                {
                    var result = MessageBox.Show("Are You Sure You Want To Remove This Order?", "Remove Order", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        if (pageHandler.CheckIfOrderExist(id))
                        {
                            if (pageHandler.DeleteOrder(id))
                                MessageBox.Show("Order Successfully Removed");
                            else
                                MessageBox.Show("Error, Order Wasn't Removed");
                        }
                        else
                            MessageBox.Show($"No Order With Id: {IdTxt.Text} Was Found");
                    }


                }
                else
                    MessageBox.Show("Invalid Id");
            }



        }
    }
}
