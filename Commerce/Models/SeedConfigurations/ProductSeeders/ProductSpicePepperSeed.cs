using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductSpicePepperSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
    new Product
    {
        Id = new Guid("cdaa001f-1848-4ff2-b6dc-8e92b1e59d01"),
        Name = "Schwartz Ground Black Pepper",
        IsFeatured = false,
        Price = 25.00m,
        Stock = 100,
        Image = "schwartz-black-pepper.jpg",
        Brand = "Schwartz",
        Description = "Schwartz Ground Black Pepper är en kryddig och aromatisk peppar av hög kvalitet. Perfekt för att ge en rik och robust smak till en mängd olika rätter.",
        ShortDescription = "Kryddig och aromatisk.",
        ProductFacts = "Ger en rik och robust smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("ad82dd68-e180-46a7-aa3b-bf8cd908e686"),
        Name = "McCormick Pure Ground Black Pepper",
        IsFeatured = false,
        Price = 30.00m,
        Stock = 120,
        Image = "mccormick-black-pepper.jpg",
        Brand = "McCormick",
        Description = "McCormick Pure Ground Black Pepper är en finmald och kraftfull peppar som ger en djup och fyllig smak till en mängd olika maträtter. Perfekt för att krydda både kött och grönsaker.",
        ShortDescription = "Finmald och kraftfull.",
        ProductFacts = "Ger en djup och fyllig smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("b52234d3-d85f-47b5-89ad-d26118d00aaf"),
        Name = "Simply Organic Black Pepper",
        IsFeatured = false,
        Price = 28.00m,
        Stock = 80,
        Image = "simply-organic-black-pepper.jpg",
        Brand = "Simply Organic",
        Description = "Simply Organic Black Pepper är en ekologisk och hållbart producerad peppar av högsta kvalitet. Perfekt för att krydda dina favoriträtter med en naturlig och distinkt smak.",
        ShortDescription = "Ekologisk och hållbart producerad.",
        ProductFacts = "Naturlig och distinkt smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("d5e6f4d9-85b7-478b-b351-f4a8c063b86c"),
        Name = "Badia Ground Black Pepper",
        IsFeatured = false,
        Price = 22.00m,
        Stock = 90,
        Image = "badia-black-pepper.jpg",
        Brand = "Badia",
        Description = "Badia Ground Black Pepper är en kryddig och aromatisk peppar av hög kvalitet som ger en rik och distinkt smak till dina maträtter. Perfekt för att krydda både sallader och såser.",
        ShortDescription = "Kryddig och aromatisk.",
        ProductFacts = "Ger en rik och distinkt smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("3e7ac9e1-c276-4aee-a6b9-68d6898f2b70"),
        Name = "Frontier Co-op Organic Tellicherry Black Peppercorns",
        IsFeatured = false,
        Price = 35.00m,
        Stock = 110,
        Image = "frontier-coop-black-pepper.jpg",
        Brand = "Frontier Co-op",
        Description = "Frontier Co-op Organic Tellicherry Black Peppercorns är handplockade och ekologiskt odlade svarta pepparkorn av högsta kvalitet. Perfekt för att mala till färskt kryddpulver som ger en intensiv och robust smak till dina rätter.",
        ShortDescription = "Handplockade och ekologiskt odlade.",
        ProductFacts = "Ger en intensiv och robust smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("802d0199-3cd8-4a0d-8fa7-c52b46b0d936"),
        Name = "Spice Islands Ground Black Pepper",
        IsFeatured = false,
        Price = 32.00m,
        Stock = 100,
        Image = "spice-islands-black-pepper.jpg",
        Brand = "Spice Islands",
        Description = "Spice Islands Ground Black Pepper är en finmald och aromatisk peppar som ger en rik och robust smak till dina favoriträtter. Perfekt för att krydda både kött och grönsaker.",
        ShortDescription = "Finmald och aromatisk.",
        ProductFacts = "Ger en rik och robust smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("3bc0101f-1aa3-46e8-8a62-86e9467ff376"),
        Name = "Penzey's Extra Coarse Ground Black Pepper",
        IsFeatured = false,
        Price = 30.00m,
        Stock = 90,
        Image = "penzeys-black-pepper.jpg",
        Brand = "Penzey's",
        Description = "Penzey's Extra Coarse Ground Black Pepper är en grovmald och kryddig peppar som ger en intensiv och fyllig smak till dina maträtter. Perfekt för att använda som en kryddig rub för grillat kött eller fisk.",
        ShortDescription = "Grovmald och kryddig.",
        ProductFacts = "Ger en intensiv och fyllig smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("9c9cbf77-af8b-4224-b4e8-365517d17027"),
        Name = "Morton & Bassett Organic Black Peppercorns",
        IsFeatured = false,
        Price = 38.00m,
        Stock = 80,
        Image = "morton-bassett-black-pepper.jpg",
        Brand = "Morton & Bassett",
        Description = "Morton & Bassett Organic Black Peppercorns är handplockade och ekologiskt odlade svarta pepparkorn av hög kvalitet. Perfekt för att mala till färskt kryddpulver som ger en intensiv och kryddig smak till dina maträtter.",
        ShortDescription = "Handplockade och ekologiskt odlade.",
        ProductFacts = "Ger en intensiv och kryddig smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("71ef1e7b-52d9-48df-91f5-0819aebc9b4e"),
        Name = "Olde Thompson Organic Black Pepper",
        IsFeatured = false,
        Price = 34.00m,
        Stock = 85,
        Image = "olde-thompson-black-pepper.jpg",
        Brand = "Olde Thompson",
        Description = "Olde Thompson Organic Black Pepper är en kryddig och aromatisk peppar av hög kvalitet som ger en rik och distinkt smak till dina favoriträtter. Perfekt för att krydda både kött och grönsaker.",
        ShortDescription = "Kryddig och aromatisk.",
        ProductFacts = "Ger en rik och distinkt smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    },
    new Product
    {
        Id = new Guid("19c7438b-75eb-43ff-8e5b-75d134142f64"),
        Name = "Simply Organic Whole Black Peppercorns",
        IsFeatured = false,
        Price = 40.00m,
        Stock = 100,
        Image = "simply-organic-black-peppercorns.jpg",
        Brand = "Simply Organic",
        Description = "Simply Organic Whole Black Peppercorns är handplockade och ekologiskt odlade svarta pepparkorn av hög kvalitet. Perfekt för att mala till färskt kryddpulver som ger en kraftfull och robust smak till dina rätter.",
        ShortDescription = "Handplockade och ekologiskt odlade.",
        ProductFacts = "Ger en kraftfull och robust smak.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a")
    });
        }
    }
}
