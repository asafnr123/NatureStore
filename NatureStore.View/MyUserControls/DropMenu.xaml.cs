using NatureStore.Model.Entitys;
using NatureStore.View.Pages.ProductsDropMenu;
using NatureStore.View.Pages.UserHomePage;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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


        public UserPage userPage { private get; set; }
        public User loggedInUser { private get; set; }


        private void protein_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new ProductPage("Protein", loggedInUser));
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }

        private void snacks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new ProductPage("Snacks", loggedInUser));
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }

        private void vitamins_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new ProductPage("Vitamins", loggedInUser));
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }

        private void creatine_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new ProductPage("Creatine", loggedInUser));
            userPage.ProducstWP.Visibility = Visibility.Hidden;
        }
    }
}
