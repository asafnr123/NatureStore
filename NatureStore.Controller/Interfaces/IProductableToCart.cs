using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller.Interfaces
{
    public interface IProductableToCart
    {
        string ProdName { get; set; }
        string ProdQuantity { get; set; }
    }
}
