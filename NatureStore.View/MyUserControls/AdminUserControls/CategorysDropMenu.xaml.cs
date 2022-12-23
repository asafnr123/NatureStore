using NatureStore.Controller;
using NatureStore.View.Pages.AdminHomePage;
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
    /// Interaction logic for CategorysDropMenu.xaml
    /// </summary>
    public partial class CategorysDropMenu : UserControl
    {

        public CategorysDropMenu()
        {
            InitializeComponent();
        }

        public AdminPage adminPage { private get; set; }
        private readonly DbReader reader = new();

        private void allCateLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.ItemsSource = null;
            adminPage.myDataGrid.ItemsSource ??= reader.GetAllCategorys();
            adminPage.MainAdminFrame.Visibility = Visibility.Hidden;
            adminPage.cateWP.Visibility = Visibility.Hidden;
            adminPage.myDataGrid.Visibility = Visibility.Visible;
        }

        private void addCateLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new AdminCategorysPage("AddCategory"));
            adminPage.cateWP.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }

        private void removeCateLbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adminPage.myDataGrid.Visibility = Visibility.Collapsed;
            adminPage.MainAdminFrame.Navigate(new AdminCategorysPage("RemoveCategory"));
            adminPage.cateWP.Visibility = Visibility.Hidden;
            adminPage.MainAdminFrame.Visibility = Visibility.Visible;
        }
    }
}
