using Commerce.Data.SeedConfigurations.IdentitySeeders;
using Commerce.Data.SeedConfigurations.ProductSeeders;
using Commerce.Models;
using Commerce.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            

            
        }
        public  DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BillingAddress> BillingAddress { get; set; }

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
            modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());



            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
