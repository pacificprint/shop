using Microsoft.EntityFrameworkCore;
using PacificPrintShop.Data.Context.PacificPrintShop;
using InstantAPIs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PacificPrintShopContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("PacificPrintShop")));
builder.Services.AddInstantAPIs(options => options.EnableSwagger = EnableSwagger.Always);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapInstantAPIs<PacificPrintShopContext>();

app.Run();