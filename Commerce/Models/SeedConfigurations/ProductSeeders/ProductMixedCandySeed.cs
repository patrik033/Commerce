using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductMixedCandySeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
           new Product
           {
               Id = new Guid("f7b1049f-463c-41da-a5ff-69f17bbf55cb"),
               Name = "Geléhallon",
               IsFeatured = true,
               Price = 8.00m, // Pris per hekto
               Stock = 100,
               Image = "geléhallon.jpg",
               Brand = "Godis AB",
               Description = "Saftiga och mjuka geléhallon i olika färger och smaker som garanterat kommer att tillfredsställa ditt sötsug.",
               ShortDescription = "Saftiga geléhallon.",
               ProductFacts = "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av gluten\n- Ej lämplig för personer med gelatinallergi",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("ddf823e5-e368-40f4-a747-74592340e6fe"),
               Name = "Lakritssnören",
               IsFeatured = false,
               Price = 10.00m, // Pris per hekto
               Stock = 120,
               Image = "lakritssnören.jpg",
               Brand = "Godis AB",
               Description = "Klassiska lakritssnören med en intensiv och fyllig smak av lakrits som kommer att tillfredsställa dina smaklökar.",
               ShortDescription = "Klassiska lakritssnören.",
               ProductFacts = "Produktfakta:\n- Innehåller gluten\n- Ej lämplig för personer med glutenintolerans\n- Kan innehålla spår av gelatin",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("fd0c9885-7f4c-4011-a6e1-4c4c838bda45"),
               Name = "Chokladpraliner",
               IsFeatured = false,
               Price = 12.00m, // Pris per hekto
               Stock = 80,
               Image = "chokladpraliner.jpg",
               Brand = "Chokladfabriken AB",
               Description = "Lyxiga chokladpraliner i olika former och fyllningar som smälter i munnen och ger en ljuvlig smakupplevelse.",
               ShortDescription = "Lyxiga chokladpraliner.",
               ProductFacts = "Produktfakta:\n- Innehåller mjölk och nötter\n- Kan innehålla spår av gluten och soja\n- Ej lämplig för personer med allergier mot mjölk eller nötter",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("ee155a6e-bf18-41f0-8ef5-b17719d005af"),
               Name = "Surkola",
               IsFeatured = false,
               Price = 6.00m, // Pris per hekto
               Stock = 90,
               Image = "surkola.jpg",
               Brand = "Godis AB",
               Description = "Syrliga och saftiga surkolor som ger en smakexplosion i munnen och är perfekta för dig som älskar det sura godiset.",
               ShortDescription = "Syrliga surkolor.",
               ProductFacts = "Produktfakta:\n- Kan innehålla spår av gelatin\n- Ej lämplig för personer med känslig magslemhinna\n- Överdriven konsumtion kan vara skadlig för tänderna",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("ad2376e2-cdf2-4bc9-ba35-86e40cd8b97d"),
               Name = "Jordgubbsremmar",
               IsFeatured = false,
               Price = 8.00m, // Pris per hekto
               Stock = 110,
               Image = "jordgubbsremmar.jpg",
               Brand = "Godis AB",
               Description = "Söta och saftiga jordgubbsremmar som är perfekta att tugga på och njuta av en underbar smak av solmogna jordgubbar.",
               ShortDescription = "Söta jordgubbsremmar.",
               ProductFacts = "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av mjölk och soja\n- Ej lämplig för personer med allergier mot jordgubbar",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("fe27c2fa-7285-4fb3-9204-0b5b7c87f379"),
               Name = "Karamellkolor",
               IsFeatured = false,
               Price = 7.00m, // Pris per hekto
               Stock = 100,
               Image = "karamellkolor.jpg",
               Brand = "Godis AB",
               Description = "Mjuka och sega karamellkolor i olika färger och smaker som kommer att föra dig tillbaka till barndomens godisminnen.",
               ShortDescription = "Mjuka karamellkolor.",
               ProductFacts = "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av mjölk och nötter\n- Ej lämplig för personer med allergier mot mjölk eller nötter",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("93ffddc9-900c-4736-a9c9-6be1a85989c9"),
               Name = "Surisar",
               IsFeatured = false,
               Price = 9.00m, // Pris per hekto
               Stock = 60,
               Image = "surisar.jpg",
               Brand = "Godis AB",
               Description = "Surisar är små, syrliga godisbitar som är en perfekt kombination av sötma och surhet och ger dig en smakfull upplevelse.",
               ShortDescription = "Små syrliga surisar.",
               ProductFacts = "Produktfakta:\n- Kan innehålla spår av gelatin\n- Ej lämplig för personer med känslig magslemhinna\n- Överdriven konsumtion kan vara skadlig för tänderna",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("f8e56652-bcc1-40ec-b6cc-b5a2c882e76c"),
               Name = "Marängsviss",
               IsFeatured = false,
               Price = 11.00m, // Pris per hekto
               Stock = 90,
               Image = "marängsviss.jpg",
               Brand = "Godis AB",
               Description = "Krispiga och luftiga maränger täckta med choklad och strössel som smälter i munnen och ger en himmelsk smakupplevelse.",
               ShortDescription = "Krispiga marängsviss.",
               ProductFacts = "Produktfakta:\n- Kan innehålla spår av ägg och mjölk\n- Ej lämplig för personer med ägg- eller mjölkallergi\n- Överdriven konsumtion kan vara skadlig för tänderna",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("1ea26f7c-bd3c-40a2-a286-9f7b2a570bed"),
               Name = "Skumgodis",
               IsFeatured = false,
               Price = 9.00m, // Pris per hekto
               Stock = 80,
               Image = "skumgodis.jpg",
               Brand = "Godis AB",
               Description = "Mjukt och luftigt skumgodis i olika färger och former som smälter i munnen och ger en söt och behaglig smakupplevelse.",
               ShortDescription = "Mjukt skumgodis.",
               ProductFacts = "Produktfakta:\n- Fri från gelatin\n- Kan innehålla spår av mjölk och soja\n- Ej lämplig för personer med allergier mot mjölk eller soja",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           },
           new Product
           {
               Id = new Guid("1abf4be2-bac4-4f3f-84d9-f485962a403d"),
               Name = "Salta Fiskar",
               IsFeatured = false,
               Price = 8.00m, // Pris per hekto
               Stock = 70,
               Image = "salta-fiskar.jpg",
               Brand = "Godis AB",
               Description = "Salta fiskar är små godisbitar som kombinerar den salta smaken av lakrits med en söt och seg konsistens för en spännande smakupplevelse.",
               ShortDescription = "Salta lakritsfiskar.",
               ProductFacts = "Produktfakta:\n- Innehåller gluten\n- Ej lämplig för personer med glutenintolerans\n- Kan innehålla spår av gelatin",
               IsForLegalAge = false,
               ProductCategoryId = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e")
           });

        }
    }
}
