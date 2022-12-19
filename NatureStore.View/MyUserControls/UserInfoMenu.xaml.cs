using NatureStore.Model.Entitys;
using NatureStore.View.Pages.Login;
using NatureStore.View.Pages.UserHomePage;
using NatureStore.View.Pages.UserOrders;
using NatureStore.View.Pages.UserProfilePage;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace NatureStore.View.MyUserControls
{
    /// <summary>
    /// Interaction logic for UserInfoMenu.xaml
    /// </summary>
    public partial class UserInfoMenu : UserControl
    {
        public UserInfoMenu()
        {
            InitializeComponent();
        }

        public User LoggedInUser { private get; set; }
        public UserPage userPage { get; set; }


        private void profile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.UserWP.Visibility = Visibility.Collapsed;
            userPage.HomeFrame.Navigate(new ProfilePage(LoggedInUser));
        }

        private void orders_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.UserWP.Visibility = Visibility.Collapsed;
            userPage.HomeFrame.Navigate(new UserOrdersPage(LoggedInUser));
        }

        private void logOut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
