using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductSnusSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product
               {
                   Id = new Guid("00fa2179-1a79-437e-9514-9e48857f51f5"),
                   Name = "General Classic Portion",
                   IsFeatured = true,
                   Price = 45.00m,
                   Stock = 100,
                   Image = "general-classic.jpg",
                   Brand = "Swedish Match",
                   Description = "General Classic Portion är en traditionell snus med en tydlig tobakssmak och en balanserad fuktighet. Perfekt för dem som uppskattar en klassisk och pålitlig snusupplevelse.",
                   ShortDescription = "Traditionell snus",
                   ProductFacts = "Innehåller nikotin",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("09c13be3-5ed9-4c53-9a51-8cc09e00c08c"),
                   Name = "Ettan Original Portion",
                   IsFeatured = true,
                   Price = 50.00m,
                   Stock = 120,
                   Image = "ettan-original.jpg",
                   Brand = "Swedish Match",
                   Description = "Ettan Original Portion är en klassisk snus med en rund och rik smakprofil. Perfekt för dem som söker en välbalanserad och traditionell snusupplevelse.",
                   ShortDescription = "Klassisk snus",
                   ProductFacts = "Innehåller tobaksextrakt",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("130b0491-3cf6-4d52-9d25-8e7c5a7bb31e"),
                   Name = "Göteborgs Rapé White Portion",
                   IsFeatured = false,
                   Price = 48.00m,
                   Stock = 80,
                   Image = "goteborgs-rape-white.jpg",
                   Brand = "Swedish Match",
                   Description = "Göteborgs Rapé White Portion är en mild och frisk snus med en lätt tobakssmak och inslag av citrus och lavendel. Perfekt för dem som söker en uppfriskande och aromatisk snusupplevelse.",
                   ShortDescription = "Mild och frisk snus",
                   ProductFacts = "Låg fuktighet",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("16bca26d-4d89-468b-8f22-90cc5e9b26db"),
                   Name = "Skruf Super White Slim Fresh",
                   IsFeatured = false,
                   Price = 55.00m,
                   Stock = 90,
                   Image = "skruf-super-white.jpg",
                   Brand = "Skruf",
                   Description = "Skruf Super White Slim Fresh är en vit och tobaksfri snus med en frisk och mintig smak. Perfekt för dem som vill njuta av en snusupplevelse utan tobak.",
                   ShortDescription = "Tobaksfri snus med mintsmak",
                   ProductFacts = "Helt fri från tobak",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("2e0b90c4-8a10-47e2-9a2f-17432d0790ab"),
                   Name = "Nick & Johnny Green Ice White",
                   IsFeatured = false,
                   Price = 52.00m,
                   Stock = 110,
                   Image = "nick-johnny-green-ice.jpg",
                   Brand = "Swedish Match",
                   Description = "Nick & Johnny Green Ice White är en kraftfull snus med en svalkande smak av mint och en frisk tobakston. Perfekt för dem som söker en intensiv och uppfriskande snusupplevelse.",
                   ShortDescription = "Kraftfull snus med mintsmak",
                   ProductFacts = "Hög nikotinhalt",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("341c55fb-1874-4b97-b23a-d9069ed4dc4f"),
                   Name = "Skruf Original Portion",
                   IsFeatured = false,
                   Price = 47.00m,
                   Stock = 100,
                   Image = "skruf-original.jpg",
                   Brand = "Skruf",
                   Description = "Skruf Original Portion är en klassisk svensk snus med en balanserad och robust tobakssmak. Perfekt för dem som uppskattar en traditionell och pålitlig snusupplevelse.",
                   ShortDescription = "Klassisk svensk snus",
                   ProductFacts = "Tillverkad enligt svenska traditioner",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("35e4481e-12ac-41ae-9dbb-d3b29ac7479b"),
                   Name = "Kronan Original Portion",
                   IsFeatured = true,
                   Price = 46.00m,
                   Stock = 60,
                   Image = "kronan-original.jpg",
                   Brand = "Kronan",
                   Description = "Kronan Original Portion är en klassisk och robust snus med en fyllig tobakssmak. Perfekt för dem som söker en kraftfull och traditionell snusupplevelse.",
                   ShortDescription = "Robust snus",
                   ProductFacts = "Klassiskt svenskt recept",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("3d85573a-5b41-4d3d-9f4f-3ee28dd01e54"),
                   Name = "Granit White Portion",
                   IsFeatured = true,
                   Price = 49.00m,
                   Stock = 85,
                   Image = "granit-white.jpg",
                   Brand = "Fiedler & Lundgren",
                   Description = "Granit White Portion är en mild och rund snus med en ren tobakssmak. Perfekt för dem som söker en diskret och behaglig snusupplevelse.",
                   ShortDescription = "Mild och rund snus",
                   ProductFacts = "Ren tobakssmak",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("51669ac3-fffd-4663-9816-d46016a30a2c"),
                   Name = "Thunder X Slim White Dry",
                   IsFeatured = false,
                   Price = 54.00m,
                   Stock = 75,
                   Image = "thunder-x-slim.jpg",
                   Brand = "V2 Tobacco",
                   Description = "Thunder X Slim White Dry är en extra stark snus med en kraftig tobakssmak och en låg fuktighetsnivå. Perfekt för dem som söker en intensiv och långvarig snusupplevelse.",
                   ShortDescription = "Extra stark snus",
                   ProductFacts = "Låg fuktighet för långvarig smak",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               },
               new Product
               {
                   Id = new Guid("64b10bb4-6b11-4399-9480-e8c4af7f2064"),
                   Name = "Jakobsson's Melon Mini Portion",
                   IsFeatured = false,
                   Price = 53.00m,
                   Stock = 70,
                   Image = "jakobssons-melon.jpg",
                   Brand = "Gotlandssnus",
                   Description = "Jakobsson's Melon Mini Portion är en frisk och söt snus med en välbalanserad smak av saftig melon. Perfekt för dem som söker en mild och fruktig snusupplevelse.",
                   ShortDescription = "Frisk och söt snus med melonsmak",
                   ProductFacts = "Fruktig och mild",
                   IsForLegalAge = true,
                   ProductCategoryId = new Guid("572d1a92-5e15-4602-b150-01a2923224c6")
               });

        }
    }
}
