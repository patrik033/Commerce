using Commerce.Data;
using Commerce.Email.Azure;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Commerce.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
        //identity
      
        //identity options
        //public static void ConfigureIdentityOptions(this IServiceCollection services)
        //{
        //    services.Configure<IdentityOptions>(options =>
        //    {
        //        options.SignIn.RequireConfirmedEmail = true;

        //        options.Tokens.ProviderMap.Add("CustomEmailConfirmation",
        //            new TokenProviderDescriptor(
        //                typeof(CustomEmailConfirmationTokenProvider<ApplicationUser>)));

        //        options.Tokens.EmailConfirmationTokenProvider = "CustomEmailConfirmation";

        //        options.Tokens.ProviderMap.Add("PasswordReset",
        //            new TokenProviderDescriptor(
        //                typeof(PasswordResetTokenProvider<ApplicationUser>)));

        //        options.Tokens.PasswordResetTokenProvider = "PasswordReset";

        //        //options.Password.RequireDigit = true;
        //        //options.Password.RequiredLength = 6;
        //        //options.Password.RequireLowercase = true;
        //        //options.Password.RequireUppercase = true;
        //        //options.Password.RequireNonAlphanumeric = true;
        //    });
        //}
        //authenticatíon options
       


        public static async Task ConfigureAzure(this IServiceCollection services, IConfiguration configuration)
        {
            var azureKeyVault = new AzureKeyVault(configuration);
            await azureKeyVault.Initialize();
            services.AddSingleton(azureKeyVault);
        }

        //swagger config
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n " +
                    "Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\n" +
                    "Example: \"Bearer 12345aasdäd\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = JwtBearerDefaults.AuthenticationScheme
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
             {
             new OpenApiSecurityScheme
                {
                 Reference = new OpenApiReference
                 {
                     Type = ReferenceType.SecurityScheme,
                     Id = "Bearer"
                 },
                 Scheme = "oauth2",
                 Name = "Bearer",
                 In = ParameterLocation.Header
                },
                 new List<string>()
             }
                });
            });
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
        }

      




        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
