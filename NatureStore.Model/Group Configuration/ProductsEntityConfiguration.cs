using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NatureStore.Model.Entitys;


namespace NatureStore.Model.Group_Configuration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        private readonly GroupConfigurationHandler handler = new();

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Name = "OP Double Rich Chocolate 2.27KG",
                    Category =  handler.GetCategoryByName("Protein"),
                    Price = 114.02f,
                    Description = "Optimum Nutrition, Gold Standard 100% Whey, Double Rich Chocolate, 24G Protein, 5 lbs (2.27 kg)",
                    Brand = "Optimum Nutrition",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Protein1.jpg"
                },
                new Product
                {
                    Name = "MP Combat Strawberry 2.27KG",
                    Category = handler.GetCategoryByName("Protein"),
                    Price = 89.76f,
                    Description = "MusclePharm, Combat 100% Whey Protein, Strawberry, 25G Protein, 5 lbs (2,269 g)",
                    Brand = "MusclePharm",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Protein2.jpg"
                },
                new Product
                {
                    Name = "CGN Very Vanilla 0.9KG",
                    Category = handler.GetCategoryByName("Protein"),
                    Price = 36.5f,
                    Description = "California Gold Nutrition, 100% Whey Protein Isolate, Very Vanilla Flavor, 27G Protein, 2 lbs (907 g)",
                    Brand = "California Gold Nutrition",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Protein3.jpg"
                },
                new Product
                {
                    Name = "OP Coffee 2.27KG",
                    Category = handler.GetCategoryByName("Protein"),
                    Price = 113.87f,
                    Description = "Optimum Nutrition, Gold Standard 100% Whey, Coffee, 24G Protein, 5 lbs (2.27 kg)",
                    Brand = "Optimum Nutrition",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Protein4.jpg"
                },
                new Product
                {
                    Name = "OP Banana Cream 2.27KG",
                    Category = handler.GetCategoryByName("Protein"),
                    Price = 113.87f,
                    Description = "Optimum Nutrition, Gold Standard 100% Whey, Banana Cream, 24G Protein, 5 lb (2.27 kg)",
                    Brand = "Optimum Nutrition",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Protein5.jpg"
                },
                new Product
                {
                    Name = "CGN Gold C",
                    Category = handler.GetCategoryByName("Vitamins"),
                    Price = 2f,
                    Description = "California Gold Nutrition, Gold C, USP Grade Vitamin C, 1,000 mg, 60 Veggie Capsules",
                    Brand = "California Gold Nutrition",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Vitamin1.jpg"
                },
                
                // number 7
                new Product
                {
                    Name = "Snack Mix Cherry Cocoa Almond Coconut",
                    Category = handler.GetCategoryByName("Snacks"),
                    Price = 7.32f,
                    Description = "Sahale Snacks, Snack Mix, Cherry Cocoa Almond Coconut , (128 g)",
                    Brand = "Sahale Snacks",
                    Image = "/NatureStore//NatureStore.View//Pages//ProductsDropMenu//Pictures//Snack1.jpg"
                },

                new Product
                {
                    Name = "",
                    Category = handler.GetCategoryByName("Snacks"),
                    Price = 0f,
                    Description = "",
                    Brand = "",
                    Image = ""
                }


                );
        }
    }
}

