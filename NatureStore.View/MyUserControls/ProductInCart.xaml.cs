using NatureStore.Controller.Interfaces;
using System.Windows.Controls;


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
