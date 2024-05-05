using Commerce.Data;
using Commerce.Extensions;
using Commerce.Models.Pagination;
using Commerce.Services.Email;
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




//mailprovider for tokens

//injections for auth services


//configurations for reset password and confirm email

builder.Services.AddScoped<EmailRegistrationSuccessfullConsumer>();


builder.Services.ConfigureSqlContext(builder.Configuration);





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
