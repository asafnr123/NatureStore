using NatureStore.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class NewProductHandler
    {
        private readonly NatureStoreDbContext db;

        public NewProductHandler()
        {
            this.db = DbConnector.GetInstance().GetDb();
        }


        public bool CheckCategoryId(string idString)
        {
            int id = 0;
            if (int.TryParse(idString, out id))
            {
                var query = from cate in db.Categories
                            select cate.Id;

                if (query.Contains(id))
                    return true;
                else
                    return false;
            }
            else
                return false;
            
        }

        public bool CheckBrand(string brand)
        {
            if (brand.Length > 1)
                return true;
            else
                return false;
        }

        public bool CheckPrice(string price)
        {
            float priceFloat = 0;


            if (float.TryParse(price, out priceFloat))
                return true;
            else
                return false;
        }

        public bool CheckName(string name)
        {
            if (name.Length > 2)
                return true;
            else
                return false;
        }

        public bool CheckDescription(string description)
        {
            if (description.Length >= 0)
                return true;
            else
                return false;
        }

        public bool CheckImage(string Img)
        {
            if (File.Exists(Img))
                return true;
            else
                return false;
        }

        public bool CheckIfProductExist(string idStr)
        {
            int id = 0;
            if (int.TryParse(idStr, out id))
            {
                var query = from prod in db.Products
                            select prod.Id;

                if (query.Contains(id))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
