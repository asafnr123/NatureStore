using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NatureStore.Model.Entitys;


namespace NatureStore.Model.Group_Configuration
{
    internal class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {

           

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "OP Double Rich Chocolate 2.27KG",
                    CategoryId = 1,
                    Price = 114.02f,
                    Description = "Optimum Nutrition, Gold Standard 100% Whey, Double Rich Chocolate, 24G Protein, 5 lbs (2.27 kg)",
                    Brand = "Optimum Nutrition",
                    Image = "Pictures//Protein1.jpg"
                },

                new Product
                {
                    Id = 2,
                    Name = "MP Combat Strawberry 2.27KG",
                    CategoryId = 1,
                    Price = 89.76f,
                    Description = "MusclePharm, Combat 100% Whey Protein, Strawberry, 25G Protein, 5 lbs (2,269 g)",
                    Brand = "MusclePharm",
                    Image = "Pictures//Protein2.jpg"
                },

                new Product
                {
                    Id = 3,
                    Name = "CGN Very Vanilla 0.9KG",
                    CategoryId = 1,
                    Price = 36.5f,
                    Description = "California Gold Nutrition, 100% Whey Protein Isolate, Very Vanilla Flavor, 27G Protein, 2 lbs (907 g)",
                    Brand = "California Gold Nutrition",
                    Image = "Pictures//Protein3.jpg"
                },

                new Product
                {
                    Id = 4,
                    Name = "OP Coffee 2.27KG",
                    CategoryId = 1,
                    Price = 113.87f,
                    Description = "Optimum Nutrition, Gold Standard 100% Whey, Coffee, 24G Protein, 5 lbs (2.27 kg)",
                    Brand = "Optimum Nutrition",
                    Image = "Pictures//Protein4.jpg"
                },

                new Product
                {
                    Id = 5,
                    Name = "OP Banana Cream 2.27KG",
                    CategoryId = 1,
                    Price = 113.87f,
                    Description = "Optimum Nutrition, Gold Standard 100% Whey, Banana Cream, 24G Protein, 5 lb (2.27 kg)",
                    Brand = "Optimum Nutrition",
                    Image = "Pictures//Protein5.jpg"
                },

                new Product
                {
                    Id = 6,
                    Name = "CGN Gold C",
                    CategoryId = 3,
                    Price = 2f,
                    Description = "California Gold Nutrition, Gold C, USP Grade Vitamin C, 1,000 mg, 60 Veggie Capsules",
                    Brand = "California Gold Nutrition",
                    Image = "Pictures//Vitamin1.jpg"
                },
                
                new Product
                {
                    Id = 7,
                    Name = "Snack Mix Cherry Cocoa Almond Coconut",
                    CategoryId = 2,
                    Price = 7.32f,
                    Description = "Sahale Snacks, Snack Mix, Cherry Cocoa Almond Coconut , (128 g)",
                    Brand = "Sahale Snacks",
                    Image = "Pictures//Snack1.jpg"
                },

                new Product
                {
                    Id = 8,
                    Name = "Snack Mix, Sea Salt Bean + Nut",
                    CategoryId = 2,
                    Price = 6.75f,
                    Description = "Sahale Snacks, Snack Mix, Sea Salt Bean + Nut, (113 g)",
                    Brand = "Sahale Snacks",
                    Image = "Pictures//Snack2.jpg"
                },

                new Product
                {
                    Id = 9,
                    Name = "CGN - Dark Chocolate",
                    CategoryId = 2,
                    Price = 15f,
                    Description = "California Gold Nutrition, FOODS - Dark Chocolate, Nuts, & Sea Salt Bar Gold Bar, 12 Bars",
                    Brand = "California Gold Nutrition",
                    Image = "Pictures//Snack3.jpg"
                },

                new Product
                {
                    Id = 10,
                    Name = "CGN - Peanut & Dark Chocolate",
                    CategoryId = 2,
                    Price = 15f,
                    Description = "California Gold Nutrition, FOODS, Peanut & Dark Chocolate Chunk Bars, 12 Bars, (40 g) Each",
                    Brand = "California Gold Nutrition",
                    Image = "Pictures//Snack4.jpg"
                },

                new Product
                {
                    Id = 11,
                    Name = "Nature's Bounty, Super B-Complex",
                    CategoryId = 3,
                    Price = 16.15f,
                    Description = "Nature's Bounty, Super B-Complex with Folic Acid Plus Vitamin C, 150 Coated Tablets",
                    Brand = "Nature's Bounty",
                    Image = "Pictures//Vitamin2.jpg"
                },

                new Product
                {
                    Id = 12,
                    Name = "CGN - Vitamin D3",
                    CategoryId = 3,
                    Price = 6f,
                    Description = "Nature's Bounty, Super B-Complex with Folic Acid Plus Vitamin C, 150 Coated California Gold Nutrition, Vitamin D3, 125 mcg, 90 Fish Gelatin Softgels",
                    Brand = "California Gold Nutrition",
                    Image = "Pictures//Vitamin3.jpg"
                },

                new Product
                {
                    Id = 13,
                    Name = "Multi Vitamin for Adults, Raspberry",
                    CategoryId = 3,
                    Price = 11.4f,
                    Description = "YumV's, Multi Vitamin for Adults, Raspberry, 60 Jelly Vitamins",
                    Brand = "YumV's",
                    Image = "Pictures//Vitamin4.jpg"
                },

                new Product
                {
                    Id = 14,
                    Name = "Multi Vitamin for Adults, Vita-Min-Herb, Men's Multivitamin",
                    CategoryId = 3,
                    Price = 67.32f,
                    Description = "Pure Synergy, Vita-Min-Herb, Men's Multivitamin, 120 Tablets",
                    Brand = "Pure Synergy",
                    Image = "Pictures//Vitamin5.jpg"
                },

                new Product
                {
                    Id = 15,
                    Name = "Active Creatine Monohydrate, Unflavored",
                    CategoryId = 4,
                    Price = 26.36f,
                    Description = "Sunwarrior, Sport, Active Creatine Monohydrate, Unflavored, (300 g)",
                    Brand = "Sunwarrior",
                    Image = "Pictures//Creatine1.jpg"
                },
                
                new Product
                {
                    Id = 16,
                    Name = "Platinum 100% Creatine, Unflavored",
                    CategoryId = 4,
                    Price = 40.07f,
                    Description = "MuscleTech, Essential Series, Platinum 100% Creatine, Unflavored, 14.11 oz (400 g)",
                    Brand = "MuscleTech",
                    Image = "Pictures//Creatine2.jpg"
                },

                new Product
                {
                    Id = 17,
                    Name = "ON Micronized Creatine Capsules",
                    CategoryId = 4,
                    Price = 64.39f,
                    Description = "Optimum Nutrition, Micronized Creatine Capsules, 2.5 g, 200 Capsules",
                    Brand = "Optimum Nutrition",
                    Image = "Pictures//Creatine3.jpg"
                },

                new Product
                {
                    Id = 18,
                    Name = "Life Extension Creatine",
                    CategoryId = 4,
                    Price = 13.49f,
                    Description = "Life Extension, Creatine Capsules, 120 Capsules",
                    Brand = "Life Extension",
                    Image = "Pictures//Creatine4.jpg"
                }

                );
        }
    }
}

