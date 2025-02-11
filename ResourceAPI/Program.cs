using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ResourceAPI;
using ResourceAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<ICoffeeShopService, CoffeeShopService>();

var app = builder.Build();

app.MapControllers();

app.Run();
