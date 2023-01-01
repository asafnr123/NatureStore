using NatureStore.Controller;
using NatureStore.Controller.Enums;
using NatureStore.Model.Entitys;
using System.Windows;
using System.Windows.Controls;


namespace NatureStore.View.Pages.AdminHomePage
{
    /// <summary>
    /// Interaction logic for NewUserPage.xaml
    /// </summary>
    public partial class NewUserPage : Page
    {
        public NewUserPage()
        {
            InitializeComponent();
        }
        FormController pageHandler = new FormController();
        DbReader reader = new();
        DbUpdater updater = new();


        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            var userType = (ComboBoxItem)userTypeCombox.SelectedItem;

            if (pageHandler.ValidateUsername(username.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Username Is Too Short");

            else if (pageHandler.ValidateUsername(username.Text) == FormStatus.UsernameInvalid)
                MessageBox.Show("Username Is Invalid");

            else if (pageHandler.CheckIfUserTaken(username.Text) == FormStatus.UsernameTaken)
                MessageBox.Show("Username Is Taken");

            else if (pageHandler.ValidatePassword(password.Password) == FormStatus.LengthTooShort)
                MessageBox.Show("Password Is Too Short");

            else if (pageHandler.ValidateAddress(address.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Address Is Invalid");

            else if (pageHandler.ValidateCitry(city.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Citry Is Invalid");

            else if (pageHandler.ValidateCountry(country.Text) == FormStatus.LengthTooShort)
                MessageBox.Show("Country Is Invalid");

            else
            {
                User user = new User(username.Text, password.Password, address.Text, city.Text, country.Text);
                if (userType != null)
                {
                    if (userType.Content.ToString() == "Admin")
                        user.UserType = Model.UserType.Admin;
                    else
                        user.UserType = Model.UserType.User;
                }
                else
                {
                    MessageBox.Show("Choose A User Type");
                    return;
                }

                pageHandler.AddUserToDb(user);
                MessageBox.Show("Successfully Registered");
            }
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            username.Text = "";
            password.Password = "";
            address.Text = "";
            city.Text = "";
            country.Text = "";
            userTypeCombox.SelectedItem = null;
        }

        private void removeUserBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;

            if (int.TryParse(userIdTxt.Text, out id))
            {
                User selectedUser = reader.GetUserById(id);
                if (selectedUser != null)
                {
                    MessageBoxResult result = MessageBox.Show("Are You Sure You Want To Delete This User?", "Remove User", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        updater.RemoveUser(id);
                        MessageBox.Show("User Successfully Removed");
                    }
                }
                else
                    MessageBox.Show($"No User With Id: {userIdTxt.Text}");
            }
            else
                MessageBox.Show("Invalid Id");
        }
    }
}
