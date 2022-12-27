using NatureStore.Model.Context;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Group_Configuration
{
    internal class GroupConfigurationHandler
    {
        private readonly NatureStoreDbContext _context = new NatureStoreDbContext();

        public Category GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Name == name);
            if (category != null)
                return category;
            else
                return null;
        }
        


    }
}
