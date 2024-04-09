using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductSpiceBBQ : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("f13e2e28-9361-4267-b06c-d03b89290561"),
                    Name = "Klassisk BBQ Rub",
                    IsFeatured = false,
                    Price = 35.00m,
                    Stock = 40,
                    Image = "classic-bbq-rub.jpg",
                    Brand = "Grill Masters",
                    Description = "En klassisk blandning av kryddor och kryddor, inklusive paprika, vitlökspulver, brunt socker och cayennepeppar, perfekt för att lägga till smak och djup till grillat kött, fågel och grönsaker.",
                    ShortDescription = "Klassisk kryddblandning för grillning",
                    ProductFacts = "Innehåller paprika, vitlökspulver och cayennepeppar",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                },
                new Product
                {
                    Id = new Guid("b59e0917-c529-497d-a37d-26b97d8f451f"),
                    Name = "Rökig Chipotle-krydda",
                    IsFeatured = false,
                    Price = 38.00m,
                    Stock = 35,
                    Image = "chipotle-seasoning.jpg",
                    Brand = "Grill Masters",
                    Description = "En rökig och kryddig blandning av chipotlepeppar, rökt paprika, vitlök och lök, perfekt för att lägga till en djärv och smakrik kick till grillat kött, skaldjur och grönsaker.",
                    ShortDescription = "Rökig kryddblandning med chipotle",
                    ProductFacts = "Innehåller rökt paprika och lök",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                },
                new Product
                {
                    Id = new Guid("f567409b-f435-4b97-9ba7-51bcf92a4bbf"),
                    Name = "Honungsbourbon-glasyr",
                    IsFeatured = false,
                    Price = 40.00m,
                    Stock = 30,
                    Image = "honey-bourbon-glaze.jpg",
                    Brand = "Grill Masters",
                    Description = "En söt och kryddig glasyr gjord med honung, bourbonwhiskey, senap och kryddor, perfekt för att karamellisera grillat kött, kyckling och revben.",
                    ShortDescription = "Söt glasyr med honung och bourbon",
                    ProductFacts = "Innehåller bourbonwhiskey och senap",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                },
                new Product
                {
                    Id = new Guid("93b5a3de-2d08-45cd-b804-88d93117e2c7"),
                    Name = "Kryddig Cajun Rub",
                    IsFeatured = false,
                    Price = 36.00m,
                    Stock = 45,
                    Image = "cajun-rub.jpg",
                    Brand = "Grill Masters",
                    Description = "En eldig blandning av Cajun-kryddor, inklusive cayennepeppar, paprika, vitlök och lök, perfekt för att lägga till en djärv och zestig smak till grillad räkor, fisk och fågel.",
                    ShortDescription = "Eldig Cajun kryddblandning",
                    ProductFacts = "Innehåller eldig cayennepeppar och paprika",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                },
                new Product
                {
                    Id = new Guid("eabf62f8-cb30-45f5-aa14-b63b6c0631e4"),
                    Name = "Lönnsirap Bourbon-glasyr",
                    IsFeatured = false,
                    Price = 42.00m,
                    Stock = 38,
                    Image = "maple-bourbon-glaze.jpg",
                    Brand = "Grill Masters",
                    Description = "En rik och smakfull glasyr gjord med lönnsirap, bourbonwhiskey, brunt socker och kryddor, perfekt för att lägga till en söt och rökig finish till grillat fläskkött, nötkött och kyckling.",
                    ShortDescription = "Rik glasyr med lönnsirap och bourbon",
                    ProductFacts = "Innehåller lönnsirap och bourbonwhiskey",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                },
                new Product
                {
                    Id = new Guid("c58f02db-fa44-47d1-97d5-4e1778a12e07"),
                    Name = "Vitlök och örtmarinad",
                    IsFeatured = false,
                    Price = 37.00m,
                    Stock = 42,
                    Image = "garlic-herb-marinade.jpg",
                    Brand = "Grill Masters",
                    Description = "En doftande och kryddig marinad gjord med vitlök, rosmarin, timjan och citron, perfekt för att infusera grillat kött, kyckling och grönsaker med läcker smak.",
                    ShortDescription = "Vitlök och örtmarinad för grillning",
                    ProductFacts = "Innehåller doftande vitlök och kryddig rosmarin",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                },
                new Product
                {
                    Id = new Guid("16aee36f-d1cb-4979-88fc-b7fc540e8360"),
                    Name = "Kansas City BBQ-sås",
                    IsFeatured = false,
                    Price = 39.00m,
                    Stock = 37,
                    Image = "kansas-city-bbq-sauce.jpg",
                    Brand = "Grill Masters",
                    Description = "En kryddig och rökig barbecue-sås med en hint av sötma, perfekt för att smeta över ribs, kycklingvingar och hamburgare för en autentisk smak av Kansas City.",
                    ShortDescription = "Kryddig BBQ-sås från Kansas City",
                    ProductFacts = "Innehåller rökig smak med en hint av sötma",
                    IsForLegalAge = false,
                    ProductCategoryId = new Guid("d72b840d-44ab-4205-b526-02111d87691b")
                });
        }
    }
}
