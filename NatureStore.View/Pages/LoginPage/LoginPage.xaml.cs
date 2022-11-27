using NatureStore.Controller;
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

namespace NatureStore.View.Pages.LoginPage
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

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            this.username = usernameTxt.Text;
            this.password = PassTxt.Password;

            if(reader.CheckIfUserExistInDb(username, password))
                MessageBox.Show("Welcome");
            else
                MessageBox.Show("Username Or Password Are Incorrect");

        }
    }
}
