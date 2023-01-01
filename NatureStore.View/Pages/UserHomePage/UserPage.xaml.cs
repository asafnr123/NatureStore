using NatureStore.Controller;
using NatureStore.Model.Entitys;
using NatureStore.View.Pages.AboutAndContact;
using NatureStore.View.Pages.UserCart;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace NatureStore.View.Pages.UserHomePage
{
    public partial class UserPage : Page
    {
        public UserPage(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            this.productsMenu.userPage = this;
            this.productsMenu.loggedInUser = loggedInUser;

            this.userInfoMenu.LoggedInUser = loggedInUser;
            this.userInfoMenu.userPage = this;
        }

        private User loggedInUser { get; set; }
        private readonly CartHandler cartHandler = new CartHandler();

        private void HouseIcon_Clicked(object sender, MouseEventArgs e)
        {
            this.HomeFrame.Navigate(new HomePage());
        }



        private void Products_MouseEnter(object sender, RoutedEventArgs e)
        {
            ProducstWP.Visibility = Visibility.Visible;
        }
        

        private void ProducstWP_MouseLeave(object sender, MouseEventArgs e)
        {
            ProducstWP.Visibility = Visibility.Hidden;
        }


        private void UserIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            UserWP.Visibility = Visibility.Visible;
        }

        private void UserWP_MouseLeave(object sender, MouseEventArgs e)
        {
            UserWP.Visibility = Visibility.Hidden;
        }

        private void Cart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.HomeFrame.Navigate(new CartPage(this.cartHandler.GetProductsInCart, this.loggedInUser));
        }

        private void Products_MouseEnter(object sender, MouseEventArgs e)
        {
            ProducstWP.Visibility = Visibility.Visible;
        }

        private void about_Clicked(object sender, MouseButtonEventArgs e)
        {
            this.HomeFrame.Navigate(new AboutPage());
        }

        private void contact_Clicked(object sender, MouseButtonEventArgs e)
        {
            this.HomeFrame.Navigate(new ContactPage());

        }
    }
}
