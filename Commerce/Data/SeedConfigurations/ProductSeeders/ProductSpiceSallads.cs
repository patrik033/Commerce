using Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.SeedConfigurations.ProductSeeders
{
    public class ProductSpiceSallads : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product
                {
                    Id = new Guid("c5ee9149-109f-48c6-b5bc-1de8224b9073"),
                    Name = "Balsamvinäger",
                    IsFeatured = false,
                    Price = 25.00m,
                    Stock = 50,
                    Image = "balsamic-vinegar.jpg",
                    Brand = "Kryddmästarna",
                    Description = "En söt och syrlig balsamvinäger som är perfekt för att dressa sallader, grönsaker och grillat kött.",
                    ShortDescription = "Söt och syrlig.",
                    ProductFacts = "Perfekt för att dressa sallader och grillat kött.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("e9d8700d-98a3-4054-a4f3-f9fe779ef07d"),
                    Name = "Olivolja",
                    IsFeatured = true,
                    Price = 30.00m,
                    Stock = 45,
                    Image = "olive-oil.jpg",
                    Brand = "Kryddmästarna",
                    Description = "En kvalitativ och smakrik extra jungfruolivolja som är perfekt för att dressa sallader, pasta och bröd.",
                    ShortDescription = "Kvalitativ och smakrik.",
                    ProductFacts = "Perfekt för att dressa sallader och pasta.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("ba791d95-5d46-4d89-b9c8-2919c063be45"),
                    Name = "Citronpeppar",
                    IsFeatured = false,
                    Price = 18.00m,
                    Stock = 55,
                    Image = "lemon-pepper.jpg",
                    Brand = "Kryddmästarna",
                    Description = "En aromatisk och frisk citronpepparblandning som är perfekt för att krydda sallader, fisk och kyckling.",
                    ShortDescription = "Aromatisk och frisk.",
                    ProductFacts = "Perfekt för att krydda sallader, fisk och kyckling.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("67684b6b-7da3-4846-b45c-bd0a46002b27"),
                    Name = "Caesardressing",
                    IsFeatured = false,
                    Price = 20.00m,
                    Stock = 60,
                    Image = "caesar-dressing.jpg",
                    Brand = "Kryddmästarna",
                    Description = "En krämig och smakrik Caesardressing som är perfekt för att toppa sallader, wraps och sandwichar.",
                    ShortDescription = "Krämig och smakrik.",
                    ProductFacts = "Perfekt för att toppa sallader och wraps.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("39265ae1-9d07-4e90-b826-9835609ffecb"),
                    Name = "Hasselnötter",
                    IsFeatured = false,
                    Price = 22.00m,
                    Stock = 40,
                    Image = "hazelnuts.jpg",
                    Brand = "Kryddmästarna",
                    Description = "Knapriga och krämiga hasselnötter som är perfekta för att strö över sallader, frukostblandningar och bakverk.",
                    ShortDescription = "Knapriga och krämiga.",
                    ProductFacts = "Perfekta för att strö över sallader och bakverk.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("bf8d1562-1cb1-4e02-90eb-927e204ccf2e"),
                    Name = "Rödvinsvinäger",
                    IsFeatured = false,
                    Price = 25.00m,
                    Stock = 50,
                    Image = "red-wine-vinegar.jpg",
                    Brand = "Kryddmästarna",
                    Description = "En robust och aromatisk rödvinsvinäger som är perfekt för att dressa sallader, marinader och såser.",
                    ShortDescription = "Robust och aromatisk.",
                    ProductFacts = "Perfekt för att dressa sallader och marinader.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("88a2c83a-f3f8-49a4-99c2-50b9110eb518"),
                    Name = "Sesamfrön",
                    IsFeatured = false,
                    Price = 20.00m,
                    Stock = 45,
                    Image = "sesame-seeds.jpg",
                    Brand = "Kryddmästarna",
                    Description = "Smakrika och knapriga sesamfrön som är perfekta för att strö över sallader, nudlar och asiatiska rätter.",
                    ShortDescription = "Smakrika och knapriga.",
                    ProductFacts = "Perfekta för att strö över sallader och asiatiska rätter.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("07dd33c3-8a87-4d30-8d84-2d40376c0e43"),
                    Name = "Rödlök",
                    IsFeatured = false,
                    Price = 18.00m,
                    Stock = 55,
                    Image = "red-onion.jpg",
                    Brand = "Kryddmästarna",
                    Description = "Färska och krispiga rödlökar som är perfekta för att tillsätta smak och knaprighet till sallader, tacos och burgare.",
                    ShortDescription = "Färska och krispiga.",
                    ProductFacts = "Perfekta för att tillsätta smak och knaprighet till sallader, tacos och burgare.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("47b409ec-32e8-4721-a091-0048e7f7fd4e"),
                    Name = "Krutonger",
                    IsFeatured = false,
                    Price = 20.00m,
                    Stock = 60,
                    Image = "croutons.jpg",
                    Brand = "Kryddmästarna",
                    Description = "Knaperiga och smakrika krutonger som är perfekta för att strö över sallader och soppor eller som ett krispigt tillbehör till dina favoriträtter.",
                    ShortDescription = "Knaperiga och smakrika.",
                    ProductFacts = "Perfekta för att strö över sallader och soppor.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                },
                new Product
                {
                    Id = new Guid("e4c2aacc-cd08-4597-97a0-ec7a3d44697c"),
                    Name = "Salladskrydda",
                    IsFeatured = true,
                    Price = 15.00m,
                    Stock = 65,
                    Image = "salad-seasoning.jpg",
                    Brand = "Kryddmästarna",
                    Description = "En härlig blandning av kryddor och örter som är perfekt för att ge sallader en extra smakboost.",
                    ShortDescription = "Härlig blandning av kryddor och örter.",
                    ProductFacts = "Perfekt för att ge sallader en extra smakboost.",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8")
                });
        }
    }
}
