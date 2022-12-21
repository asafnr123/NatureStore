using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller.Interfaces
{
    public interface IDbUpdater
    {
        bool UpdateProdName(int id, string newName);
        bool UpdateProdCategory(int id, int cateId);
        bool UpdateProdPrice(int id, string price);
        bool UpdateProdDesc(int id, string description);
        bool UpdateProdBrand(int id, string brand);
        bool UpdateProdImg(int id, string newImg);



    }
}
