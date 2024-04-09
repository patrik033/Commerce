using Commerce.Models;
using Commerce.Models.SeedConfigurations;
using Commerce.Models.SeedConfigurations.ProductSeeders;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data
{
    public class AppDbContext : DbContext
    {

        public  DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
