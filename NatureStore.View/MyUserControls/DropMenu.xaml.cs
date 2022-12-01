using NatureStore.View.Pages.ProductsDropMenu;
using NatureStore.View.Pages.UserHomePage;
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

namespace NatureStore.View.MyUserControls
{
    /// <summary>
    /// Interaction logic for DropMenu.xaml
    /// </summary>
    public partial class DropMenu : UserControl
    {
        public DropMenu()
        {
            InitializeComponent();
        }


        public UserPage userPage { get; set; }


        private void protein_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new ProteinPage());
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }

        private void snacks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new SnacksPage());
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }

        private void vitamins_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new VitaminsPage());
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }

        private void creatine_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new CreatinePage());
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }
    }
}
