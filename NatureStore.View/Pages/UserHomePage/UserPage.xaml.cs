using NatureStore.View.MyUserControls;
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

namespace NatureStore.View.Pages.UserHomePage
{
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();

        }


        
        private void Products_MouseEnter(object sender, RoutedEventArgs e)
        {
                ProducstWP.Visibility = Visibility.Visible;
        }
        
        private void ProducstWP_MouseLeave(object sender, MouseEventArgs e)
        {
            ProducstWP.Visibility = Visibility.Hidden;
        }
        private void HouseIcon_Clicked(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new UserPage());
        }


    }
}
