using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Group_Configuration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category> 
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Name = "Protein",
                    Description = "protein shakes"
                },
                new Category
                {
                    Name = "Snacks",
                    Description = "protein snacks and healthy snacks"
                },
                new Category
                {
                    Name = "Vitamins",
                    Description = "vitamins pills and some more healthy stuffs",
                },
                new Category
                {
                    Name = "Creatine",
                    Description = "Creatine"
                });
        }
    }
}
