using Commerce.Data;
using Commerce.Email.Azure;
using Commerce.Email.Token;
using Commerce.Models.Identity;
using Commerce.Password;
using Commerce.Services.Identity;
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
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
            }).AddEntityFrameworkStores<AppDbContext>();
        }
        //identity options
        public static void ConfigureIdentityOptions(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;

                options.Tokens.ProviderMap.Add("CustomEmailConfirmation",
                    new TokenProviderDescriptor(
                        typeof(CustomEmailConfirmationTokenProvider<ApplicationUser>)));

                options.Tokens.EmailConfirmationTokenProvider = "CustomEmailConfirmation";

                options.Tokens.ProviderMap.Add("PasswordReset",
                    new TokenProviderDescriptor(
                        typeof(PasswordResetTokenProvider<ApplicationUser>)));

                options.Tokens.PasswordResetTokenProvider = "PasswordReset";

                //options.Password.RequireDigit = true;
                //options.Password.RequiredLength = 6;
                //options.Password.RequireLowercase = true;
                //options.Password.RequireUppercase = true;
                //options.Password.RequireNonAlphanumeric = true;
            });
        }
        //authenticatíon options
        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var key = configuration.GetValue<string>("ApiSettings:Secret");


            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "https://localhost:5001",
                    ValidAudience = "https://localhost:5001",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                };

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = ctx =>
                    {
                        ctx.Request.Cookies.TryGetValue("accessToken", out var accessToken);
                        if(!string.IsNullOrEmpty(accessToken))
                            ctx.Token = accessToken;

                        return Task.CompletedTask;
                    }
                };
            });
        }


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

        public static void ConfigureAuthInjections(this IServiceCollection services)
        {
            services.AddScoped<IUserRegistrationService, UserRegistrationService>();
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IConfirmAccountService, ConfirmAccountService>();
            services.AddScoped<IUpdateAccount, UpdateAccount>();
            services.AddScoped<IResetService, ResetService>();
            services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            services.AddScoped<IRevokeToken, RevokeTokenService>();
        }




        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
