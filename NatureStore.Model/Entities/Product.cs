using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AllowNull]
        public Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }

    }
}
