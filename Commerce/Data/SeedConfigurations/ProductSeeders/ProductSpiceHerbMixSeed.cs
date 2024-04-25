using Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.SeedConfigurations.ProductSeeders
{
    public class ProductSpiceHerbMixSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
              new Product
              {
                  Id = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2"),
                  Name = "Italiensk Kryddblandning",
                  IsFeatured = false,
                  Price = 25.00m,
                  Stock = 40,
                  Image = "italian-seasoning.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En klassisk blandning av italienska örter, inklusive basilika, oregano, rosmarin och timjan, perfekt för att lägga till smak till pasta, pizza och sallader.",
                  ShortDescription = "Klassisk italiensk örtblandning för pasta och pizza.",
                  ProductFacts = "Innehåller basilika, oregano, rosmarin och timjan.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("6c0b83db-34aa-4de7-bf2f-3b2aa4c1a14a"),
                  Name = "Mexikansk Kryddblandning",
                  IsFeatured = false,
                  Price = 30.00m,
                  Stock = 35,
                  Image = "mexican-spice-mix.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En kryddig blandning av mexikanska kryddor, inklusive chilipulver, spiskummin, paprika och vitlök, perfekt för att ge en extra kick till tacos, burritos och fajitas.",
                  ShortDescription = "Kryddig mix för tacos och burritos.",
                  ProductFacts = "Innehåller chilipulver, spiskummin, paprika och vitlök.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("3f8dc7e5-2c18-472a-a847-97912e2d0879"),
                  Name = "Asiatisk Wokkrydda",
                  IsFeatured = false,
                  Price = 28.00m,
                  Stock = 30,
                  Image = "asian-stir-fry-seasoning.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En aromatisk blandning av asiatiska kryddor, inklusive ingefära, vitlök, sojasås och sesamfrön, perfekt för att krydda wokrätter, nudlar och risrätter.",
                  ShortDescription = "Aromatisk mix för asiatisk wok.",
                  ProductFacts = "Innehåller ingefära, vitlök, sojasås och sesamfrön.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("91963e79-b529-40c0-94cf-4975e8464c5b"),
                  Name = "Medelhavsörterblandning",
                  IsFeatured = false,
                  Price = 27.00m,
                  Stock = 45,
                  Image = "mediterranean-herb-mix.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En smakfull blandning av medelhavskryddor, inklusive persilja, timjan, basilika och oregano, perfekt för att krydda grillat kött, grönsaker och skaldjur.",
                  ShortDescription = "Smakfull mix för medelhavsrätter.",
                  ProductFacts = "Innehåller persilja, timjan, basilika och oregano.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("5bcf6b1c-bd7e-4e7d-8803-c62db9d5f777"),
                  Name = "Indisk Currykrydda",
                  IsFeatured = false,
                  Price = 32.00m,
                  Stock = 25,
                  Image = "indian-curry-spice.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En doftande blandning av indiska kryddor, inklusive currypulver, gurkmeja, spiskummin och koriander, perfekt för att ge djup och smak till curryrätter, grytor och risrätter.",
                  ShortDescription = "Doftande mix för indisk curry.",
                  ProductFacts = "Innehåller currypulver, gurkmeja, spiskummin och koriander.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("ca01c900-ff13-47e3-81a4-fdaddc905688"),
                  Name = "Herbes de Provence",
                  IsFeatured = false,
                  Price = 26.00m,
                  Stock = 38,
                  Image = "herbes-de-provence.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En traditionell blandning av provencalska örter, inklusive lavendel, mejram, libbsticka och timjan, perfekt för att krydda rostat kött, grönsaker och soppor med en fransk touch.",
                  ShortDescription = "Traditionell mix för franska rätter.",
                  ProductFacts = "Innehåller lavendel, mejram, libbsticka och timjan.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("c7d45df1-fde9-4b7d-b3dc-186ea8b46f6a"),
                  Name = "Za'atar från Mellanöstern",
                  IsFeatured = false,
                  Price = 29.00m,
                  Stock = 33,
                  Image = "zaatar.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En doftande blandning av örter från Mellanöstern, inklusive timjan, sumak, sesamfrön och oregano, perfekt för att strö över flatbröd, sallader och dippsåser.",
                  ShortDescription = "Doftande mix för Mellanösterns kök.",
                  ProductFacts = "Innehåller timjan, sumak, sesamfrön och oregano.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("0f64b525-6c14-4815-8a7a-7e202c5352cf"),
                  Name = "Karibisk Jerkkrydda",
                  IsFeatured = false,
                  Price = 31.00m,
                  Stock = 27,
                  Image = "caribbean-jerk-seasoning.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En kryddig och aromatisk blandning av karibiska kryddor, inklusive kryddpeppar, kanel, muskotnöt och habaneropeppar, perfekt för att ge värme och smak till grillat kött, skaldjur och grönsaker.",
                  ShortDescription = "Aromatisk mix för karibiska rätter.",
                  ProductFacts = "Innehåller kryddpeppar, kanel, muskotnöt och habaneropeppar.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("08d3cc5b-9ac4-4d8b-b7de-d5c16f1c83b5"),
                  Name = "Franska Herbes de Provence",
                  IsFeatured = false,
                  Price = 26.50m,
                  Stock = 36,
                  Image = "french-herbes-de-provence.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En klassisk blandning av franska örter, inklusive rosmarin, timjan, mejram och dragon, perfekt för att krydda rostat kött, fågel och grönsaker.",
                  ShortDescription = "Klassisk mix för franska rätter.",
                  ProductFacts = "Innehåller rosmarin, timjan, mejram och dragon.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              },
              new Product
              {
                  Id = new Guid("ed700aa7-38d8-45b4-80f3-4954696fb999"),
                  Name = "Asiatisk Currykrydda",
                  IsFeatured = false,
                  Price = 30.50m,
                  Stock = 29,
                  Image = "asian-curry-powder.jpg",
                  Brand = "Kryddmästarna",
                  Description = "En doftande och smakrik blandning av asiatiska kryddor, inklusive gurkmeja, ingefära, spiskummin och koriander, perfekt för att ge en exotisk twist till curryrätter, soppor och wokrätter.",
                  ShortDescription = "Doftande mix för asiatisk curry.",
                  ProductFacts = "Innehåller gurkmeja, ingefära, spiskummin och koriander.",
                  IsForLegalAge = false,
                  ProductCategoryId = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2")
              });
        }
    }
}
