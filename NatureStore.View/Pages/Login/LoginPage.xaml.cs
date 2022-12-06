using NatureStore.Controller;
using NatureStore.Model.Entitys;
using NatureStore.View.Pages.AdminHomePage;
using NatureStore.View.Pages.UserHomePage;
using System.Windows;
using System.Windows.Controls;


namespace NatureStore.View.Pages.Login
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private DbReader reader = new();
        private string username;
        private string password;
        private User user;

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            this.username = usernameTxt.Text;
            this.password = PassTxt.Password;
            if(reader.CheckIfUserExistInDb(username, password))
            {
                // return true if user is admin
                if (reader.CheckUserTypeByUsername(username))
                    this.NavigationService.Navigate(new AdminPage());
                else
                {
                    this.user = reader.GetUser(username, password);
                    this.NavigationService.Navigate(new UserPage(user));
                }
            }
            else
                MessageBox.Show("Username Or Password Are Incorrect");
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegisterPage());
        }

    }
}
