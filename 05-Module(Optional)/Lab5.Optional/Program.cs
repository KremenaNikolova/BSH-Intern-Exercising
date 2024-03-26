using Lab5.Optional.DbContexts;
using Lab5.Optional.Models;
using Lab5.Optional.Repositories;
using Lab5.Optional.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IProductsRepository<Food>, ProductsRepository<Food>>();
builder.Services.AddScoped<IProductsRepository<Clothing>, ProductsRepository<Clothing>>();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
