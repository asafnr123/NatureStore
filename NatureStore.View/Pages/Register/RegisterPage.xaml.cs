using NatureStore.Controller;
using NatureStore.Controller.Enums;
using NatureStore.Model.Entitys;
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

namespace NatureStore.View.Pages.Login
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.username.Text = "";
            this.password.Password = "";
            this.address.Text = "";
            this.city.Text = "";
            this.country.Text = "";
        }



        private FormController pageController = new();




        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            this.username.Text = "";
            this.password.Password = "";
            this.address.Text = "";
            this.city.Text = "";
            this.country.Text = "";
        }

        private void SubmititBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (pageController.ValidateUsername(username.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Username Is Too Short");

            else if (pageController.ValidateUsername(username.Text) == FormStatus.UsernameInvalid)
                MessageBox.Show("Username Is Invalid");

            else if (pageController.CheckIfUserTaken(username.Text) == FormStatus.UsernameTaken)
                MessageBox.Show("Username Is Taken");

            else if (pageController.ValidatePassword(password.Password) == FormStatus.LengthTooShort)
                MessageBox.Show("Password Is Too Short");

            else if (pageController.ValidateCountry(country.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Country Is Invalid");

            else if (pageController.ValidateCitry(city.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Citry Is Invalid");

            else if (pageController.ValidateAddress(address.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Address Is Invalid");

            else
            {
                User user = new User(username.Text, password.Password, address.Text, city.Text, country.Text);
                user.UserType = Model.UserType.User;
                pageController.AddUserToDb(user);
                MessageBox.Show("Successfully Registered"); 
            }
            




        }
    }
}
