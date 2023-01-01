using NatureStore.Controller;
using NatureStore.Model.Entitys;
using NatureStore.View.MyUserControls;
using System.Windows.Controls;


namespace NatureStore.View.Pages.UserOrders
{
    /// <summary>
    /// Interaction logic for UserOrdersPage.xaml
    /// </summary>
    public partial class UserOrdersPage : Page
    {
        public UserOrdersPage(User user)
        {
            InitializeComponent();
            SetUserOrdersInPage(user);
        }

        private DbReader reader = new();

        private void SetUserOrdersInPage(User u)
        {
            var userOrders = reader.GetUserOrders(u);

            if(userOrders != null)
            {
                userOrdersSP.Children.Clear();
                userOrders.ForEach(x =>
                {
                    var orderInOrder = new OrdersInUserOrders();
                    orderInOrder.OrderNum = x.OrderNumber;
                    orderInOrder.Prod = x.Prod;
                    orderInOrder.Quantity = x.Quantity;
                    orderInOrder.OrderDate = x.OrderDate;
                    orderInOrder.Price = x.Price;
                    userOrdersSP.Children.Add(orderInOrder);
                });
            }
        }


    }
}
