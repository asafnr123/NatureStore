using NatureStore.Controller;
using System.Windows;
using System.Windows.Controls;

namespace NatureStore.View.Pages.AdminHomePage
{
    /// <summary>
    /// Interaction logic for AddNewStockPage.xaml
    /// </summary>
    public partial class AddNewStockPage : Page
    {
        public AddNewStockPage()
        {
            InitializeComponent();
        }

        private readonly StockHandler pageHandler = new();

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!pageHandler.CheckProductId(prodIdTxt.Text))
                MessageBox.Show("Invalid Product Id");

            else if (!pageHandler.CheckQuantity(quantTxt.Text))
                MessageBox.Show("Invalid Quantity");

            else
            {
                if (pageHandler.SubmitNewStock(prodIdTxt.Text, quantTxt.Text))
                    MessageBox.Show("Successfully Added Stock");
                else
                    MessageBox.Show("Product Id Already In Stock");
            }

        }
    }
}
