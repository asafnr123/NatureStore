using NatureStore.Model.Entitys;
using System.Windows.Controls;


namespace NatureStore.View.Pages.UserProfilePage
{
    /// <summary>
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage(User user)
        {
            InitializeComponent();
            UserInfo(user);
        }


        private void UserInfo(User u)
        {
            if (u != null)
            {
                usernameLbl.Content += u.UserName;
                addressLbl.Content += u.Address;
                cityLbl.Content += u.City;
                countryLbl.Content += u.Country;
            }
        }
    }
}
