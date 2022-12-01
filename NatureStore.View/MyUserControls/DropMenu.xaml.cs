using NatureStore.View.Pages.ProteinProductsPage;
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

namespace NatureStore.View.MyUserControls
{
    /// <summary>
    /// Interaction logic for DropMenu.xaml
    /// </summary>
    public partial class DropMenu : UserControl
    {
        public DropMenu()
        {
            InitializeComponent();
        }


        public UserPage Login { get; set; } = new UserPage();


        private void protein_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login.HomeFrame.Navigate(new ProteinPage());
        }

        private void snacks_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void vitamins_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void creatine_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
