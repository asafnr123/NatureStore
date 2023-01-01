using NatureStore.Controller;
using System.Windows;
using System.Windows.Controls;


namespace NatureStore.View.Pages.AdminHomePage
{
    /// <summary>
    /// Interaction logic for EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Page
    {
        public EditProductPage()
        {
            InitializeComponent();
        }

        private readonly NewProductHandler pageHandler = new();
        private readonly DbUpdater updater = new();
        private const string nameLblContent = "New Name :";
        private const string categoryLblContent = "New Category :";
        private const string priceLblContent = "New Price :";
        private const string descLblContent = "New Description :";
        private const string brandLblContent = "New Brand :";
        private const string imgLblContent = "Image Path :";


        private void editNameBtn_Click(object sender, RoutedEventArgs e)
        {
            editingBorder.Visibility = Visibility.Visible;
            Lbl1.Content = nameLblContent;
        }

        private void editCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            editingBorder.Visibility = Visibility.Visible;
            Lbl1.Content = categoryLblContent;
        }

        private void editPriceBtn_Click(object sender, RoutedEventArgs e)
        {
            editingBorder.Visibility = Visibility.Visible;
            Lbl1.Content = priceLblContent;
        }

        private void editDescBtn_Click(object sender, RoutedEventArgs e)
        {
            editingBorder.Visibility = Visibility.Visible;
            Lbl1.Content = descLblContent;
        }

        private void editBrandBtn_Click(object sender, RoutedEventArgs e)
        {
            editingBorder.Visibility = Visibility.Visible;
            Lbl1.Content = brandLblContent;
        }

        private void editImgBtn_Click(object sender, RoutedEventArgs e)
        {
            editingBorder.Visibility = Visibility.Visible;
            Lbl1.Content = imgLblContent;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (Lbl1.Content)
            {
                case nameLblContent:
                    if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                        MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
                    else if (!pageHandler.CheckName(Txt1.Text))
                        MessageBox.Show("Invalid Name");
                    else
                    {
                        try
                        {
                            if(updater.UpdateProdName(int.Parse(prodIdTxt.Text), Txt1.Text))
                            {
                                MessageBox.Show("Product Name Updated");
                                prodIdTxt.Text = "";
                                Txt1.Text = "";
                            }
                            else
                                MessageBox.Show("Something Went Wrong");
                        }
                        catch
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                        
                    }
                    break;


                case categoryLblContent:
                    if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                        MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
                    else if (!pageHandler.CheckCategoryId(Txt1.Text))
                        MessageBox.Show("Invalid Category");
                    else
                    {
                        try
                        {
                            if(updater.UpdateProdCategory(int.Parse(prodIdTxt.Text), int.Parse(Txt1.Text)))
                            {
                                MessageBox.Show("Product Category Updated");
                                prodIdTxt.Text = "";
                                Txt1.Text = "";
                            }
                            else
                                MessageBox.Show("Something Went Wrong");
                        }
                        catch
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                    }
                    break;

                case priceLblContent:
                    if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                        MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
                    else if (!pageHandler.CheckPrice(Txt1.Text))
                        MessageBox.Show("Invalid Price");
                    else
                    {
                        try
                        {
                            if (updater.UpdateProdPrice(int.Parse(prodIdTxt.Text), Txt1.Text))
                            {
                                MessageBox.Show("Product Price Updated");
                                prodIdTxt.Text = "";
                                Txt1.Text = "";
                            }
                            else
                                MessageBox.Show("Something Went Wrong");
                        }
                        catch
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                    }
                    break;

                case descLblContent:
                    if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                        MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
                    else if (!pageHandler.CheckDescription(Txt1.Text))
                        MessageBox.Show("Invalid Description");
                    else
                    {
                        try
                        {
                            if (updater.UpdateProdDesc(int.Parse(prodIdTxt.Text), Txt1.Text))
                            {
                                MessageBox.Show("Product Description Updated");
                                prodIdTxt.Text = "";
                                Txt1.Text = "";
                            }
                            else
                                MessageBox.Show("Something Went Wrong");
                        }
                        catch
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                    }
                    break;

                case brandLblContent:
                    if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                        MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
                    else if (!pageHandler.CheckBrand(Txt1.Text))
                        MessageBox.Show("Invalid Description");
                    else
                    {
                        try
                        {
                            if (updater.UpdateProdBrand(int.Parse(prodIdTxt.Text), Txt1.Text))
                            {
                                MessageBox.Show("Product Brand Updated");
                                prodIdTxt.Text = "";
                                Txt1.Text = "";
                            }
                            else
                                MessageBox.Show("Something Went Wrong");
                        }
                        catch
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                    }
                    break;

                case imgLblContent:
                    if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                        MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
                    else if (!pageHandler.CheckImage(Txt1.Text))
                        MessageBox.Show("Invalid Image");
                    else
                    {
                        try
                        {
                            if (updater.UpdateProdImg(int.Parse(prodIdTxt.Text), Txt1.Text))
                            {
                                MessageBox.Show("Product Image Updated");
                                prodIdTxt.Text = "";
                                Txt1.Text = "";
                            }
                            else
                                MessageBox.Show("Something Went Wrong");
                        }
                        catch
                        {
                            MessageBox.Show("Something Went Wrong");
                        }
                    }
                    break;

                default:
                    MessageBox.Show("Something Went Wrong");
                    break;




            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!pageHandler.CheckIfProductExist(prodIdTxt.Text))
                MessageBox.Show($"Product Id {prodIdTxt.Text} Was Not Found");
            else
            {
                MessageBoxResult result = MessageBox.Show("Are You Sure You Want To Delete This Product?", "Remove Product", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    try
                    {
                        updater.RemoveProduct(int.Parse(prodIdTxt.Text));
                        MessageBox.Show("Product Removed Successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                }
            }
            
        }
    }
}
