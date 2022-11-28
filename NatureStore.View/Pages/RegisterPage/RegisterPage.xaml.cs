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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private string Username { get; set; }
        private string Password { get; set; }
        public string Address { get; set; }
        private string City { get; set; }
        private string Country { get; set; }    


        public void AssaignPropsToUserInfo()
        {
            this.Username = username.Text;
            this.Password = password.Password;
            this.Address = address.Text;
            this.City = city.Text;
            this.Country = country.Text;
        }


        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        { 
            this.username.Text = "";
            this.password.Password = "";
            this.address.Text = "";
            this.city.Text = "";
            this.country.Text = "";

        }
    }
}
