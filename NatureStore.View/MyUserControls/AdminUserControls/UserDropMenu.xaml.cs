using NatureStore.Controller;
using NatureStore.View.Pages.AdminHomePage;
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

namespace NatureStore.View.MyUserControls.AdminUserControls
{
    /// <summary>
    /// Interaction logic for UserDropMenu.xaml
    /// </summary>
    public partial class UserDropMenu : UserControl
    {
        public UserDropMenu()
        {
            InitializeComponent();
        }

        public AdminPage adminPage { private get; set; }
        private readonly DbReader reader = new();

        private void allUsersLbl_MouseEnter(object sender, MouseEventArgs e)
        {
            adminPage.myDataGrid.ItemsSource = null;
            adminPage.myDataGrid.ItemsSource ??= reader.GetAllUsers().ToList();
            adminPage.MainAdminFrame.Visibility = Visibility.Collapsed;
            adminPage.usersWp.Visibility = Visibility.Hidden;
            adminPage.myDataGrid.Visibility = Visibility.Visible;
        }

        private void addUserLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new NewUserPage());
            adminPage.usersWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }

        private void removeUserLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NewUserPage DeleteUserPage = new NewUserPage();

            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            DeleteUserPage.addUserWP.Visibility = Visibility.Collapsed;
            DeleteUserPage.removeUserBorder.Visibility = Visibility.Visible;
            adminPage.MainAdminFrame.Navigate(DeleteUserPage);
            adminPage.usersWp.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }
    }
}
