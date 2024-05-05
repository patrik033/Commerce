
using Commerce.Data.SeedConfigurations.ProductSeeders;
using Commerce.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            

            
        }
        public  DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Product seeding
            modelBuilder.ApplyConfiguration(new ProductCategorySeed());
            modelBuilder.ApplyConfiguration(new ProductCigarettesSeed());
            modelBuilder.ApplyConfiguration(new ProductDrickaSeed());
            modelBuilder.ApplyConfiguration(new ProductEnergyDrinkSeed());
            modelBuilder.ApplyConfiguration(new ProductMixedCandySeed());
            modelBuilder.ApplyConfiguration(new ProductOrdinaryCandySeed());
            modelBuilder.ApplyConfiguration(new ProductSnusSeed());
            modelBuilder.ApplyConfiguration(new ProductSpiceBBQ());
            modelBuilder.ApplyConfiguration(new ProductSpiceHerbMixSeed());
            modelBuilder.ApplyConfiguration(new ProductSpiceHerbSeed());
            modelBuilder.ApplyConfiguration(new ProductSpicePepperSeed());
            modelBuilder.ApplyConfiguration(new ProductSpiceSallads());
           
            //identity seeding
     



            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
