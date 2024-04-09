using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductCigarettesSeed : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("96ed318a-2b63-4d5a-8d28-4338b7d542b2"),
                    Name = "Marlboro Gold",
                    IsFeatured = true,
                    Price = 75.00m,
                    Stock = 100,
                    Image = "marlboro-gold.jpg",
                    Brand = "Marlboro",
                    ShortDescription = "Mild tobaksblandning med en ren och balanserad smak.",
                    Description = "Marlboro Gold är en mild tobaksblandning med en ren och balanserad smak. Perfekt för dem som föredrar en mildare rökupplevelse.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("5bc1db67-1f76-44c3-a6ef-8d9aa9627414"),
                    Name = "Camel Blue",
                    IsFeatured = false,
                    Price = 70.00m,
                    Stock = 120,
                    Image = "camel-blue.jpg",
                    Brand = "Camel",
                    ShortDescription = "Balanserad smak med en lätt och behaglig rökning.",
                    Description = "Camel Blue erbjuder en balanserad smak med en lätt och behaglig rökning. Perfekt för dem som söker en mildare och smidigare cigarettrökning.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("bc5107fc-e2f0-4c14-a2a2-6cf69dc52c39"),
                    Name = "Winston Red",
                    IsFeatured = false,
                    Price = 65.00m,
                    Stock = 80,
                    Image = "winston-red.jpg",
                    Brand = "Winston",
                    ShortDescription = "Klassisk och robust cigarett med en djup och kraftfull smak.",
                    Description = "Winston Red är en klassisk och robust cigarett med en djup och kraftfull smak. Perfekt för dem som föredrar en starkare rökupplevelse.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("5dc3e742-d887-47c3-84f6-01973a01700b"),
                    Name = "Lucky Strike Original",
                    IsFeatured = false,
                    Price = 68.00m,
                    Stock = 90,
                    Image = "luckystrike-original.jpg",
                    Brand = "Lucky Strike",
                    ShortDescription = "Ikonisk cigarett med distinkt och robust smakprofil.",
                    Description = "Lucky Strike Original är en ikonisk cigarett med en distinkt och robust smakprofil. Perfekt för dem som letar efter en autentisk och tillfredsställande rökning.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("62ed95db-0f1e-4850-a889-16c66f3a0c0b"),
                    Name = "Pall Mall Red",
                    IsFeatured = false,
                    Price = 62.00m,
                    Stock = 110,
                    Image = "pallmall-red.jpg",
                    Brand = "Pall Mall",
                    ShortDescription = "Robust och intensiv smakprofil med tydlig tobakston.",
                    Description = "Pall Mall Red är känd för sin robusta och intensiva smakprofil med en tydlig tobakston. Perfekt för dem som föredrar en kraftfull och fyllig rökning.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("e877f4e0-e1d7-491f-9fa4-d7b74a1345c2"),
                    Name = "Rothmans Blue",
                    IsFeatured = false,
                    Price = 67.00m,
                    Stock = 100,
                    Image = "rothmans-blue.jpg",
                    Brand = "Rothmans",
                    ShortDescription = "Balanserad och len rökning med distinkt tobakssmak.",
                    Description = "Rothmans Blue erbjuder en balanserad och len rökning med en distinkt tobakssmak. Perfekt för dem som söker en mild och behaglig rökupplevelse.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("26fe2d4e-95d3-46ad-9c19-12a0d4525453"),
                    Name = "Davidoff Gold",
                    IsFeatured = false,
                    Price = 80.00m,
                    Stock = 60,
                    Image = "davidoff-gold.jpg",
                    Brand = "Davidoff",
                    ShortDescription = "Premiumcigarett med elegant och subtil smakprofil.",
                    Description = "Davidoff Gold är en premiumcigarett med en elegant och subtil smakprofil. Perfekt för dem som söker en sofistikerad och förstklassig rökupplevelse.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("769ff894-42fc-4d84-9dc8-87dcde6e28a2"),
                    Name = "Benson & Hedges Gold",
                    IsFeatured = false,
                    Price = 78.00m,
                    Stock = 75,
                    Image = "benson-hedges-gold.jpg",
                    Brand = "Benson & Hedges",
                    ShortDescription = "Rik och balanserad smak med distinkt tobakskaraktär.",
                    Description = "Benson & Hedges Gold erbjuder en rik och balanserad smak med en distinkt tobakskaraktär. Perfekt för dem som uppskattar en premium cigarettupplevelse.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("20175a2b-cb60-4a53-a134-69fbbd367af9"),
                    Name = "Kent Blue",
                    IsFeatured = false,
                    Price = 73.00m,
                    Stock = 85,
                    Image = "kent-blue.jpg",
                    Brand = "Kent",
                    ShortDescription = "Jämn och balanserad rökning med distinkt tobakssmak.",
                    Description = "Kent Blue erbjuder en jämn och balanserad rökning med en distinkt tobakssmak. Perfekt för dem som söker en klassisk och tillfredsställande cigarettupplevelse.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                },
                new Product
                {
                    Id = new Guid("69f5cc21-8280-4c49-8928-3e1d1523f8dc"),
                    Name = "Prince Rich Taste",
                    IsFeatured = true,
                    Price = 69.00m,
                    Stock = 70,
                    Image = "prince-rich-taste.jpg",
                    Brand = "Prince",
                    ShortDescription = "Kraftfull och fyllig cigarett med en rik och intensiv smakprofil.",
                    Description = "Prince Rich Taste är en kraftfull och fyllig cigarett med en rik och intensiv smakprofil. Perfekt för dem som söker en djup och tillfredsställande rökning.",
                    IsForLegalAge = true,
                    ProductFacts = "Produktfakta: Förvaras vid högst 22.00°C för att bibehålla kvaliteten.",
                    ProductCategoryId = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57")
                });

        }

    }
}
