using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductDrickaSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
    new Product
    {
        Id = new Guid("d43c78e4-eece-40f2-b7cc-4cd161727265"),
        Name = "Pepsi",
        IsFeatured = true,
        Price = 360m,
        Stock = 100,
        Image = "pepsi.jpg",
        Brand = "PepsiCo",
        ShortDescription = "Frisk coladryck med en djärv smak.",
        Description = "Pepsi är en uppfriskande coladryck med en fräsch och djärv smak, perfekt för att stilla din törst på en varm sommardag eller som en uppiggande dryck under arbetet. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Förvaras svalt för bästa smakupplevelse."
    },
    new Product
    {
        Id = new Guid("d1500077-4fe8-4c17-86a1-92c4a840f7f6"),
        Name = "Coca-Cola",
        IsFeatured = true,
        Price = 360m,
        Stock = 120,
        Image = "cocacola.jpg",
        Brand = "The Coca-Cola Company",
        ShortDescription = "Klassisk coladryck med unik smak.",
        Description = "Coca-Cola är en klassisk coladryck med en unik och förfriskande smak som har varit en favorit bland dryckesälskare över hela världen i generationer. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Bäst serverad kyld."
    },
    new Product
    {
        Id = new Guid("e51998ad-3426-4ce7-bdfd-297ad6750c5e"),
        Name = "Fanta Orange",
        IsFeatured = false,
        Price = 300m,
        Stock = 80,
        Image = "fanta-orange.jpg",
        Brand = "The Coca-Cola Company",
        ShortDescription = "Söt och fruktig apelsindryck.",
        Description = "Fanta Orange är en tangy och söt apelsindryck som spricker av fruktig smak och är perfekt för att njuta av en het sommardag eller som en uppfriskande dryck under träning. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Skaka flaskan före öppning för bästa smak."
    },
    new Product
    {
        Id = new Guid("cbdcb109-4f18-4f86-81c2-50b820124c9b"),
        Name = "Sprite",
        IsFeatured = false,
        Price = 295m,
        Stock = 90,
        Image = "sprite.jpg",
        Brand = "The Coca-Cola Company",
        ShortDescription = "Krispig citron-lime soda.",
        Description = "Sprite är en krispig och klar citron-lime soda med en uppfriskande smak som är idealisk för att stilla din törst och lämna dig känslan uppfriskad. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Bäst serverad väl kyld."
    },
    new Product
    {
        Id = new Guid("36989985-66a1-40da-90d9-ac24e0ab001f"),
        Name = "Mountain Dew",
        IsFeatured = false,
        Price = 425m,
        Stock = 110,
        Image = "mountain-dew.jpg",
        Brand = "PepsiCo",
        ShortDescription = "Citrusig soda med koffeinboost.",
        Description = "Mountain Dew är en djärv och citrusig soda med en kick av koffein för en energigivande boost som håller dig igång hela dagen. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Innehåller koffein."
    },
    new Product
    {
        Id = new Guid("18dfc76e-6c67-4ec7-a6e9-8347f58577a3"),
        Name = "Dr Pepper",
        IsFeatured = false,
        Price = 320m,
        Stock = 100,
        Image = "drpepper.jpg",
        Brand = "Keurig Dr Pepper",
        ShortDescription = "Unik blandning av 23 smaker.",
        Description = "Dr Pepper är en distinkt blandning av 23 smaker som skapar en unik och tillfredsställande smakupplevelse som har gjort den till en favorit bland dryckesälskare. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Innehåller koffein."
    },
    new Product
    {
        Id = new Guid("54494de8-c138-4c62-b87b-cf622fc02ebc"),
        Name = "Schweppes Tonic Water",
        IsFeatured = false,
        Price = 460m,
        Stock = 60,
        Image = "schweppes-tonic.jpg",
        Brand = "Schweppes",
        ShortDescription = "Bubblande tonicvatten.",
        Description = "Schweppes Tonic Water är ett krispigt och bubblande tonicvatten perfekt för att mixa med gin eller vodka och skapa en uppfriskande och läskande drink. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Bäst serverad med is."
    },
    new Product
    {
        Id = new Guid("e0c299a9-8026-4c9b-a3c5-ba77d0397ece"),
        Name = "Nestea Peach",
        IsFeatured = false,
        Price = 270m,
        Stock = 90,
        Image = "nestea-peach.jpg",
        Brand = "Nestlé",
        ShortDescription = "Fruktig persikais.",
        Description = "Nestea Peach är en lätt och fruktig persikais med en uppfriskande smak och en mild sötma som gör den till det perfekta valet för att stilla din törst på en solig dag. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Innehåller naturliga smakämnen."
    },
    new Product
    {
        Id = new Guid("c02a7a39-85e5-4d3d-9e11-d66294fc8e5a"),
        Name = "Lipton Iced Tea",
        IsFeatured = false,
        Price = 410m,
        Stock = 80,
        Image = "lipton-iced-tea.jpg",
        Brand = "Unilever",
        ShortDescription = "Förfriskande iste.",
        Description = "Lipton Iced Tea är en förfriskande iste med en balanserad och lätt söt smak som är perfekt för att njuta av på en varm sommardag eller som ett uppiggande alternativ till kaffe. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Innehåller naturliga smakämnen."
    },
    new Product
    {
        Id = new Guid("8eab0b08-1898-4b75-a046-a29a84659f10"),
        Name = "Gatorade Lemon-Lime",
        IsFeatured = false,
        Price = 220m,
        Stock = 70,
        Image = "gatorade.jpg",
        Brand = "The Gatorade Company",
        ShortDescription = "Elektrolytpack.",
        Description = "Gatorade Lemon-Lime är en elektrolytpackad dryck som hjälper till att återställa vätskebalansen och elektrolyterna efter träning. Denna dryck är lämplig för personer i alla åldrar.",
        IsForLegalAge = false,
        ProductCategoryId = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
        ProductFacts = "Produktfakta: Innehåller elektrolyter."
    });
        }
    }
}
