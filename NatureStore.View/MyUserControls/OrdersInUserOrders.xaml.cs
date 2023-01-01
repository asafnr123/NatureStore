
using System.Windows.Controls;


namespace NatureStore.View.MyUserControls
{
    /// <summary>
    /// Interaction logic for OrdersInUserOrders.xaml
    /// </summary>
    public partial class OrdersInUserOrders : UserControl
    {
        public OrdersInUserOrders()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public int OrderNum { get; set; }
        public string Prod { get; set; }
        public string Quantity { get; set; }
        public string OrderDate { get; set; }
        public string Price { get; set; }
    }
}
