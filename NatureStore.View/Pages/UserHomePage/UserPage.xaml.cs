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
            // ProducstWP.Children.Add(new DropMenu());
        }

        private void Products_MouseLeave(object sender, RoutedEventArgs e)
        {
            // ProducstWP.Children.Clear();
        }

    }
}
