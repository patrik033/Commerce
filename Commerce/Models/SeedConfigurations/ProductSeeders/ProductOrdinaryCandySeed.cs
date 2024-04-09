using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductOrdinaryCandySeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product
                {
                    Id = new Guid("a3e389d1-5891-4037-8f6b-4922d5a35a60"),
                    Name = "Milk Chocolate Bar",
                    IsFeatured = false,
                    Price = 15.50m,
                    Stock = 100,
                    Image = "milk-chocolate-bar.jpg",
                    Brand = "Hershey's",
                    Description = "Creamy and delicious milk chocolate bar that melts in your mouth, perfect for satisfying your sweet cravings.",
                    ShortDescription = "Creamy milk chocolate bar",
                    ProductFacts = "Net weight: 100g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("88b2e422-37a9-4d56-8469-d53f780c439b"),
                    Name = "Gummy Bears",
                    IsFeatured = false,
                    Price = 12.75m,
                    Stock = 120,
                    Image = "gummy-bears.jpg",
                    Brand = "Haribo",
                    Description = "Chewy and fruity gummy bears in a variety of colors and flavors, perfect for kids and adults alike.",
                    ShortDescription = "Chewy fruity gummy bears",
                    ProductFacts = "Net weight: 150g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("25e4dc55-6f57-4a6f-bd22-3b4d0cf8ed2f"),
                    Name = "Sour Worms",
                    IsFeatured = false,
                    Price = 11.25m,
                    Stock = 80,
                    Image = "sour-worms.jpg",
                    Brand = "Trolli",
                    Description = "Tangy and chewy sour worms with a zesty coating that adds a burst of flavor with every bite, sure to tantalize your taste buds.",
                    ShortDescription = "Tangy sour worms",
                    ProductFacts = "Net weight: 120g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("6d437f17-22b3-4f1d-b6b1-8a29cb2b9c6f"),
                    Name = "Jelly Beans",
                    IsFeatured = false,
                    Price = 10.75m,
                    Stock = 90,
                    Image = "jelly-beans.jpg",
                    Brand = "Jelly Belly",
                    Description = "Assorted jelly beans with a mix of fruity flavors and vibrant colors, perfect for snacking or as a sweet treat for special occasions.",
                    ShortDescription = "Assorted fruity jelly beans",
                    ProductFacts = "Net weight: 200g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("6e860a28-5102-499d-ae76-6d857f77e390"),
                    Name = "Peanut Butter Cups",
                    IsFeatured = false,
                    Price = 18.50m,
                    Stock = 110,
                    Image = "peanut-butter-cups.jpg",
                    Brand = "Reese's",
                    Description = "Creamy peanut butter encased in smooth milk chocolate cups, a classic combination that's loved by chocolate and peanut butter enthusiasts.",
                    ShortDescription = "Creamy peanut butter cups",
                    ProductFacts = "Net weight: 180g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("c6141e15-dff1-46a1-a8ec-7a2791212a7b"),
                    Name = "Licorice Twists",
                    IsFeatured = false,
                    Price = 14.75m,
                    Stock = 100,
                    Image = "licorice-twists.jpg",
                    Brand = "Red Vines",
                    Description = "Chewy and flavorful licorice twists with a hint of sweetness, perfect for satisfying your candy cravings anytime.",
                    ShortDescription = "Chewy licorice twists",
                    ProductFacts = "Net weight: 150g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("4d1c66d4-9e5d-4cb4-bc87-8c47a4c7a1e0"),
                    Name = "M&M's",
                    IsFeatured = true,
                    Price = 13.25m,
                    Stock = 90,
                    Image = "mms.jpg",
                    Brand = "Mars",
                    Description = "Colorful and crunchy candy-coated chocolates that are fun to eat and perfect for sharing with friends and family.",
                    ShortDescription = "Colorful candy-coated chocolates",
                    ProductFacts = "Net weight: 180g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("2c0e93d1-739a-4229-b4e1-e7cb2e7b69ac"),
                    Name = "Snickers",
                    IsFeatured = true,
                    Price = 16.00m,
                    Stock = 60,
                    Image = "snickers.jpg",
                    Brand = "Mars",
                    Description = "Indulgent candy bar with layers of nougat, caramel, and peanuts covered in milk chocolate, providing a satisfying blend of flavors and textures.",
                    ShortDescription = "Indulgent candy bar with peanuts",
                    ProductFacts = "Net weight: 200g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("9e0a995a-12a1-448b-95c2-314e1884e57f"),
                    Name = "Kit Kat",
                    IsFeatured = false,
                    Price = 17.50m,
                    Stock = 85,
                    Image = "kitkat.jpg",
                    Brand = "Nestlé",
                    Description = "Classic wafer fingers covered in smooth milk chocolate, offering a crispy and creamy treat that's perfect for a quick snack or dessert.",
                    ShortDescription = "Classic wafer fingers in milk chocolate",
                    ProductFacts = "Net weight: 170g",
                    IsForLegalAge = false,

                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                },
                new Product
                {
                    Id = new Guid("b7b8c7b8-7896-4ad1-8493-fdbb497b3a4e"),
                    Name = "Twix",
                    IsFeatured = false,
                    Price = 15.75m,
                    Stock = 70,
                    Image = "twix.jpg",
                    Brand = "Mars",
                    Description = "Crunchy biscuit sticks topped with caramel and coated in milk chocolate, providing a deliciously satisfying combination of textures and flavors.",
                    ShortDescription = "Crunchy biscuit sticks with caramel",
                    ProductFacts = "Net weight: 180g",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3")
                });

        }
    }
}
