using Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.SeedConfigurations.ProductSeeders
{
    public class ProductCategorySeed : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(
            new ProductCategory
            {
                Id = new Guid("4c00f03e-e62f-430b-92c2-df95913a192b"),
                ProductCategoryName = "Dricka"
            },
            new ProductCategory
            {
                Id = new Guid("cc74f91b-91ac-4632-8636-15b7722fc3e7"),
                ProductCategoryName = "Energi Dricka"
            },
            new ProductCategory
            {
                Id = new Guid("d58f87f4-7378-447a-93d4-b888fbecfb6e"),
                ProductCategoryName = "LösGodis"
            },
            new ProductCategory
            {
                Id = new Guid("87242b00-6f72-4caa-b687-b105001e1ad3"),
                ProductCategoryName = "VanligtGodis"
            },
            new ProductCategory
            {
                Id = new Guid("1faa3b8a-6f3d-4ad3-b21a-6e43887e4a57"),
                ProductCategoryName = "Cigaretter"
            },
            new ProductCategory
            {
                Id = new Guid("572d1a92-5e15-4602-b150-01a2923224c6"),
                ProductCategoryName = "Snus"
            },

            new ProductCategory
            {
                Id = new Guid("5ac3f10e-8d41-4e6b-bdb6-1496f00ce57a"),
                ProductCategoryName = "Peppar"
            },
            new ProductCategory
            {
                Id = new Guid("aba0e880-9edb-44a2-96d8-a0cf508b5ef2"),
                ProductCategoryName = "Örtmixer"
            },
            new ProductCategory
            {
                Id = new Guid("d72b840d-44ab-4205-b526-02111d87691b"),
                ProductCategoryName = "Grillkryddor"
            },
            new ProductCategory
            {
                Id = new Guid("dc3d8822-1dec-4569-a5c7-77faea561d56"),
                ProductCategoryName = "Örter"
            },
            new ProductCategory
            {
                Id = new Guid("496adb77-621e-4abf-9fc9-8cd92a15e0f8"),
                ProductCategoryName = "Salladskryddor"
            });

        }
    }
}
