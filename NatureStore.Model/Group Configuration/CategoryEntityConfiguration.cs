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
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category> 
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Protein",
                    Description = "protein shakes"
                },
                new Category
                {
                    Id = 2,
                    Name = "Snacks",
                    Description = "protein snacks and healthy snacks"
                },
                new Category
                {
                    Id = 3,
                    Name = "Vitamins",
                    Description = "vitamins pills and some more healthy stuffs",
                },
                new Category
                {
                    Id = 4,
                    Name = "Creatine",
                    Description = "Creatine"
                });
        }
    }
}
