﻿using NatureStore.Controller;
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
            this.username.Text = "";
            this.password.Password = "";
            this.address.Text = "";
            this.city.Text = "";
            this.country.Text = "";
        }



        private RegisterPageController pageController = new();




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
            
            if (pageController.ValidateUsername(username.Text) == FormStatus.LengthToShort)
                MessageBox.Show("Username Is Too Short");

            else if (pageController.ValidatePassword(password.Password) == FormStatus.LengthToShort)
                MessageBox.Show("Password Is Too Short");

            else if (pageController.ValidateCountry(country.Text) == FormStatus.LengthToShort)
                MessageBox.Show("Country Is Invalid");

            else if (pageController.ValidateCitry(city.Text) == FormStatus.LengthToShort)
                MessageBox.Show("Citry Is Invalid");

            else if (pageController.ValidateAddress(address.Text) == FormStatus.LengthToShort)
                MessageBox.Show("Address Is Invalid");

            else
            { 
                //User user = new User(username.Text, password.Password, address.Text, city.Text, country.Text);
                //pageController.AddUserToDb(user);
                MessageBox.Show("Successfully Registered"); 
            }
            




        }
    }
}
