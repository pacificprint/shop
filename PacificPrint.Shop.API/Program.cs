using Microsoft.EntityFrameworkCore;
using InstantAPIs;
using PacificPrint.Shop.Data.Context;

var builder = WebApplication.CreateBuilder(args);
var runningInDocker = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PacificPrintContext>(o =>
{
    o.UseNpgsql(builder.Configuration.GetConnectionString(runningInDocker ? "ContainerShopConnection" : "LocalShopConnection"));
});
builder.Services.AddInstantAPIs(options => options.EnableSwagger = EnableSwagger.Always);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapInstantAPIs<PacificPrintContext>();

app.Run();