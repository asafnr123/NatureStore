using NatureStore.Controller.Interfaces;
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
    /// Interaction logic for ProductInCart.xaml
    /// </summary>
    public partial class ProductInCart : UserControl, IProductToCart
    {
        public ProductInCart()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string ProdName { get; set; }
        public string ProdQty { get; set; }

        
    }
}
