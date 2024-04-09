using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.SeedConfigurations.ProductSeeders
{
    public class ProductEnergyDrinkSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
      new Product
      {
          Id = new Guid("b8e4cce7-f7bf-4acd-afde-4e9d2f5ac0a8"),
          Name = "Red Rain",
          IsFeatured = false,
          Price = 360.00m,
          Stock = 100,
          Image = "redrain.jpg",
          Brand = "Red Rain",
          Description = "Intensiv energidryck med en kraftfull smak och en uppiggande effekt, perfekt för att hålla dig vaken och fokuserad under långa dagar. Denna produkt är avsedd för personer över laglig ålder.",
          ShortDescription = "Kraftfull energidryck.",
          ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
          IsForLegalAge = true,
          ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
      },
    new Product
    {
        Id = new Guid("79586e5a-8d91-4b6d-8ff2-ae3940640d3b"),
        Name = "Monster Assault",
        IsFeatured = true,
        Price = 480.00m,
        Stock = 70,
        Image = "monsterassault.jpg",
        Brand = "Monster Energy",
        Description = "Kraftfull energidryck med en unik smakprofil som kombinerar söta och syrliga toner för en intensiv och uppfriskande smakupplevelse. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Unik smakprofil.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    },
    new Product
    {
        Id = new Guid("c8966dd2-5bf5-4411-942f-f0a7e6f7f7a5"),
        Name = "Rockstar Punched",
        IsFeatured = false,
        Price = 540.00m,
        Stock = 90,
        Image = "rockstarpunched.jpg",
        Brand = "Rockstar Energy",
        Description = "Kraftfull energidryck med en fruktig smakexplosion av exotiska frukter och en extra boost av koffein för att hålla dig alert och redo för dagen. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Fruktig smakexplosion.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    },
    new Product
    {
        Id = new Guid("f8b08f26-d250-485d-9ebf-25aa4a8fcb49"),
        Name = "Bang Energy",
        IsFeatured = false,
        Price = 600.00m,
        Stock = 60,
        Image = "bangenergy.jpg",
        Brand = "VPX Bang",
        Description = "Explosiv energidryck med en skarp och intensiv smak som ger dig den extra kick du behöver för att övervinna utmaningarna i din dagliga rutin. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Explosiv smak.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    },
    new Product
    {
        Id = new Guid("6931503e-c3e0-443a-85e5-c2363b9d9c74"),
        Name = "Xyience Xenergy",
        IsFeatured = false,
        Price = 420.00m,
        Stock = 85,
        Image = "xyiencexenergy.jpg",
        Brand = "Xyience",
        Description = "Högeffektiv energidryck med en läcker smak av blandade bär och en uppiggande blandning av vitaminer och antioxidanter för ökad energi och fokus. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Högeffektiv energidryck.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    },
    new Product
    {
        Id = new Guid("7ad812f0-5df5-4464-8e0f-cc9b14da1653"),
        Name = "Full Throttle",
        IsFeatured = false,
        Price = 480.00m,
        Stock = 75,
        Image = "fullthrottle.jpg",
        Brand = "Full Throttle",
        Description = "Kraftfull energidryck med en robust och kryddig smakprofil och en extra kick av koffein för att hjälpa dig att hålla dig vaken och alert. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Robust och kryddig smak.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    },
    new Product
    {
        Id = new Guid("b6b445d0-c4e3-4d69-86e1-d5714d0eb8d7"),
        Name = "NOS Energy Drink",
        IsFeatured = false,
        Price = 540.00m,
        Stock = 70,
        Image = "nosenergy.jpg",
        Brand = "NOS",
        Description = "Högeffektiv energidryck med en frisk och fruktig smak av apelsin och en extra boost av taurin och koffein för att öka din prestanda och fokus. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Fruktig smak med taurinboost.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    },
    new Product
    {
        Id = new Guid("6d663a46-56f2-4c3b-8d2c-8017418ed100"),
        Name = "AMP Energy",
        IsFeatured = false,
        Price = 420.00m,
        Stock = 80,
        Image = "ampenergy.jpg",
        Brand = "AMP Energy",
        Description = "Kraftfull energidryck med en balanserad och uppfriskande smak samt en extra boost av koffein för att hjälpa dig att hålla dig vaken och alert under dagen. Denna produkt är avsedd för personer över laglig ålder.",
        ShortDescription = "Balanserad och uppfriskande smak.",
        ProductFacts = "Produktfakta:\n- Förvaras svalt och torrt\n- Innehåller koffein\n- Rekommenderas ej för barn, gravida eller ammande kvinnor",
        IsForLegalAge = true,
        ProductCategoryId = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7")
    });
        }
    }
}
