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
