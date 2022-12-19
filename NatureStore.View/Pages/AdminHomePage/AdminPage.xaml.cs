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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            this.prodDropMenu.adminPage = this;
        }

        private void products_MouseEnter(object sender, MouseEventArgs e)
        {
            productsWp.Visibility = Visibility.Visible;
        }

        private void users_MouseEnter(object sender, MouseEventArgs e)
        {
            userssWp.Visibility = Visibility.Visible;

        }

        private void productsWp_MouseLeave(object sender, MouseEventArgs e)
        {
            productsWp.Visibility = Visibility.Hidden;
        }

        private void userssWp_MouseLeave(object sender, MouseEventArgs e)
        {
            userssWp.Visibility = Visibility.Hidden;

        }

        
    }
}
