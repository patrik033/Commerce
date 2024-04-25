using Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.SeedConfigurations.ProductSeeders
{
    public class ProductSpiceHerbSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product
               {
                   Id = new Guid("b293d089-4d2b-4099-9a2c-28cb0a2ef365"),
                   Name = "Basilika",
                   IsFeatured = false,
                   Price = 15.00m,
                   Stock = 50,
                   Image = "basil.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Färsk och aromatisk basilika perfekt för att använda i pesto, tomatsås, sallader och italienska rätter.",
                   ShortDescription = "Aromatisk och fräsch.",
                   ProductFacts = "Används ofta i italienska rätter.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("9c95338e-9a30-4e3d-b80b-bae349a82d69"),
                   Name = "Rosmarin",
                   IsFeatured = false,
                   Price = 18.00m,
                   Stock = 45,
                   Image = "rosemary.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Aromatisk och talliknande rosmarin som passar utmärkt till att krydda rostad potatis, grillat kött och grönsaksrätter.",
                   ShortDescription = "Aromatisk och talliknande.",
                   ProductFacts = "Ger en härlig smak till rostat kött.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("07106d71-5e10-47f2-8b11-5da537d62134"),
                   Name = "Timjan",
                   IsFeatured = false,
                   Price = 16.00m,
                   Stock = 55,
                   Image = "thyme.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Aromatisk och jordig timjan som passar utmärkt till att krydda grytor, soppor, kyckling och fiskrätter.",
                   ShortDescription = "Aromatisk och jordig.",
                   ProductFacts = "Perfekt för att krydda grytor och soppor.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("e07803fb-760a-42a0-8c72-c7cf236c66a0"),
                   Name = "Oregano",
                   IsFeatured = false,
                   Price = 14.00m,
                   Stock = 60,
                   Image = "oregano.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Aromatisk och robust oregano som passar utmärkt till att krydda pizza, pasta, sallader och grekiska rätter.",
                   ShortDescription = "Aromatisk och robust.",
                   ProductFacts = "Klassiskt tillbehör till pizza och pasta.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("19cd6f32-1a29-4797-a3f6-86b1a1b2aeb1"),
                   Name = "Dill",
                   IsFeatured = false,
                   Price = 17.00m,
                   Stock = 40,
                   Image = "dill.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Färsk och krispig dill som passar utmärkt till att krydda fiskrätter, såser, sallader och potatis.",
                   ShortDescription = "Färsk och krispig.",
                   ProductFacts = "Perfekt till fisk och såser.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("d8d43af0-02e3-4e58-88fb-7e2260fa06de"),
                   Name = "Persilja",
                   IsFeatured = false,
                   Price = 16.00m,
                   Stock = 50,
                   Image = "parsley.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Färsk och pepprig persilja som passar utmärkt till att krydda soppor, såser, potatis och sallader.",
                   ShortDescription = "Färsk och pepprig.",
                   ProductFacts = "Klassiskt tillbehör till soppor och såser.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("67a4d4d0-b6e0-4f4e-a6b1-4ef857d821b3"),
                   Name = "Koriander",
                   IsFeatured = false,
                   Price = 15.00m,
                   Stock = 55,
                   Image = "coriander.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Aromatisk och citrusliknande koriander som passar utmärkt till att krydda asiatiska rätter, curry, salsa och guacamole.",
                   ShortDescription = "Aromatisk och citrusliknande.",
                   ProductFacts = "Passar bra i asiatiska rätter och salsa.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("d03817ec-d049-4903-b026-84c9d33b6f14"),
                   Name = "Mynta",
                   IsFeatured = false,
                   Price = 14.00m,
                   Stock = 60,
                   Image = "mint.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Färsk och uppfriskande mynta som passar utmärkt till att krydda drycker, desserter, sallader och såser.",
                   ShortDescription = "Färsk och uppfriskande.",
                   ProductFacts = "Perfekt för att krydda drycker och desserter.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("0b8d1a2a-bf8c-44d8-8109-741e21962a7b"),
                   Name = "Salvia",
                   IsFeatured = false,
                   Price = 18.00m,
                   Stock = 45,
                   Image = "sage.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Aromatisk och jordig salvia som passar utmärkt till att krydda kyckling, kalkon, soppa och såser.",
                   ShortDescription = "Aromatisk och jordig.",
                   ProductFacts = "Används ofta i kötträtter och soppor.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               },
               new Product
               {
                   Id = new Guid("bf7c6b13-778a-437b-a1b2-54d81aa18d7f"),
                   Name = "Lavendel",
                   IsFeatured = false,
                   Price = 20.00m,
                   Stock = 35,
                   Image = "lavender.jpg",
                   Brand = "Kryddmästarna",
                   Description = "Doftande och blommig lavendel som passar utmärkt till att krydda bakverk, desserter, te och marinader.",
                   ShortDescription = "Doftande och blommig.",
                   ProductFacts = "Används ofta i bakning och till desserter.",
                   IsForLegalAge = false,
                   ProductCategoryId = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56")
               });
        }
    }
}
