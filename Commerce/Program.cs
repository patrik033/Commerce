using Commerce.Data;
using Commerce.Email.Register;
using Commerce.Email.Token;
using Commerce.Extensions;
using Commerce.Models.Identity;
using Commerce.Models.Pagination;
using Commerce.Password;
using Commerce.Services.Email;
using Commerce.Services.Identity.Token;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



builder.Services.AddSingleton<ISendGridEmailRegisterService, SendGridEmailRegisterService>();
builder.Services.AddSingleton<ISendGridEmailPaymentSuccess, SendGridEmailPaymentSuccess>();
await builder.Services.ConfigureAzure(builder.Configuration);



//mailprovider for registering users
builder.Services.AddSingleton<ISendGridEmailRegister, SendGridEmailRegister>();
//mailprovider for tokens
builder.Services.AddSingleton<ISendGridEmailTokens, SendGridEmailTokens>();
//injections for auth services
builder.Services.ConfigureAuthInjections();

//configurations for reset password and confirm email
builder.Services.AddTransient<CustomEmailConfirmationTokenProvider<ApplicationUser>>();
builder.Services.AddTransient<PasswordResetTokenProvider<ApplicationUser>>();
builder.Services.AddScoped<EmailRegistrationSuccessfullConsumer>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureIdentity();
builder.Services.ConfigureIdentityOptions();
builder.Services.ConfigureAuthentication(builder.Configuration);




builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
        builder.WithExposedHeaders("X-Pagination");
    });
});

builder.Services.AddApiVersioning(x =>
{
    x.DefaultApiVersion = new ApiVersion(1, 0);
    x.AssumeDefaultVersionWhenUnspecified = true;
    x.ReportApiVersions = true;
});

builder.Services
    .AddScoped<IPagedRepo, PagedRepo>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
