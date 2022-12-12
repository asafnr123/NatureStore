using NatureStore.Model.Entitys;
using NatureStore.View.Pages.UserHomePage;
using NatureStore.View.Pages.UserProfilePage;
using System;
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

        private void profile_MouseDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userPage.HomeFrame.Navigate(new ProfilePage(LoggedInUser));
        }
    }
}
