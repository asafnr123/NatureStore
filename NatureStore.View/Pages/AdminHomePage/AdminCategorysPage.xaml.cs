using NatureStore.Controller;
using NatureStore.Model.Entitys;
using System.Windows;
using System.Windows.Controls;


namespace NatureStore.View.Pages.AdminHomePage
{
    /// <summary>
    /// Interaction logic for AdminCategorysPage.xaml
    /// </summary>
    public partial class AdminCategorysPage : Page
    {
        public AdminCategorysPage(string pageOption)
        {
            InitializeComponent();
            if (pageOption == "AddCategory")
            {
                removeCateBorder.Visibility = Visibility.Hidden;
                addCateBorder.Visibility = Visibility.Visible;
            }
            else if(pageOption == "RemoveCategory")
            {
                addCateBorder.Visibility = Visibility.Hidden;
                removeCateBorder.Visibility = Visibility.Visible;
            }
        }

        private readonly DbUpdater updater = new();
        private readonly DbCreator creator = new();
        private readonly DbReader reader = new();

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cateNameTxt.Text.Length > 2)
            {
                var category = new Category();
                category.Name = cateNameTxt.Text;
                category.Description = DescTxt.Text;
                if (creator.AddNewCategory(category))
                    MessageBox.Show("Category Successfully Added");
                else
                    MessageBox.Show("Something Went Wrong");
            }
            else
                MessageBox.Show("Category Name Is Too Short");
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;

            if (int.TryParse(cateIdTxt.Text, out id))
            {
                var userCheck = MessageBox.Show("Are You Sure You Want To Remove This Category?", "Remove Category", MessageBoxButton.YesNo);

                if(userCheck == MessageBoxResult.Yes)
                {
                    var category = reader.GetCategory(id);

                    if (category != null)
                    {
                        if (updater.RemoveCategory(id))
                            MessageBox.Show("Category Successfully Removed");
                        else
                            MessageBox.Show("Something Went Wrong");
                    }
                    else
                        MessageBox.Show($"No Category With Id: {cateIdTxt.Text} Was Found");
                }
            }
            else
                MessageBox.Show("Invalid Id");
        }
    }
}
