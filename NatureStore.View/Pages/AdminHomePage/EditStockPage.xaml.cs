using NatureStore.Controller;
using System.Windows;
using System.Windows.Controls;


namespace NatureStore.View.Pages.AdminHomePage
{
    /// <summary>
    /// Interaction logic for EditStockPage.xaml
    /// </summary>
    public partial class EditStockPage : Page
    {
        public EditStockPage()
        {
            InitializeComponent();
        }


        private readonly StockHandler pageHandler = new();

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!pageHandler.CheckProductId(prodIdTxt.Text))
                MessageBox.Show("Invalid Product Id");

            else if (!pageHandler.CheckQuantity(newQtyTxt.Text))
                MessageBox.Show("Invalid Quantity");

            else
            {
                if (pageHandler.ChangeQtyInStock(prodIdTxt.Text, newQtyTxt.Text))
                    MessageBox.Show("Successfully Edited Quantity");
                else
                    MessageBox.Show($"No Stock With Product Id {prodIdTxt.Text}");
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!pageHandler.CheckProductId(prodIdTxt.Text))
                MessageBox.Show("Invalid Product Id");

            else
            {
                var userChocice = MessageBox.Show("Are You Sure You Want To Remove This Stock?", "Remove Stock", MessageBoxButton.YesNo);
                if(userChocice == MessageBoxResult.Yes)
                {
                    if (pageHandler.RemoveStock(prodIdTxt.Text))
                        MessageBox.Show("Successfully Removed Stock");
                    else
                        MessageBox.Show($"No Stock With Product Id {prodIdTxt.Text}");
                }
            }
        }
    }
}
