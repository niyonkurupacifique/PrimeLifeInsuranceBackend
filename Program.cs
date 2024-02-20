using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using c_.Models;
using c_.INGENZIModels;
using c_.service;
using c_.service.impl;
using c_.Mappings;
using Microsoft.Extensions.Configuration;
using c_.LoanProtectionModels;
using c_.LoanProtectionTestModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<INGENZIDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionToIngenzi"));
});

 builder.Services.AddDbContext<LoanProtectionContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionToLoanProtection"));
});
 builder.Services.AddDbContext<LoanProtectionTestDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionToLoanProtectionTest"));
});

builder.Services.AddScoped<IProductProposalService, ProductProposalService>();
builder.Services.AddScoped<IProductPaymentStatement, ProductPaymentStatementService>();
builder.Services.AddScoped<ILoanProtection, LoanProtectionService>();

var _jwtSettings = builder.Configuration.GetSection("jwtSettings");
builder.Services.Configure<jwtSettings>(_jwtSettings);

// Profile map
builder.Services.AddAutoMapper(typeof(FamilyProposalMapping));

var app = builder.Build();



// Enable CORS
app.UseCors(options =>
{
    options.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});
 
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

// Use middleware components in the desired order
app.UseMiddleware<PreferredLanguageMiddleware>();
app.UseMiddleware<ProductBodySelectionMiddleware>();

app.UseHttpsRedirection();
app.UseAuthentication();

app.MapControllers();

app.Run();
