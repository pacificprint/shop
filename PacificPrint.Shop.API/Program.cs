using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using InstantAPIs;
using Microsoft.OpenApi.Models;
using PacificPrint.Shop.Data.Context;
using Swashbuckle.AspNetCore.SwaggerGen;
using PacificPrint.Shop.Core.Common_Converters;
using PacificPrint.Shop.Core.Dal;
using PacificPrint.Shop.Core.Service;

var builder = WebApplication.CreateBuilder(args);
var runningInDocker = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddRepository();
builder.Services.AddProjectServices();
builder.Services.AddCurrentUser();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString().Replace('+', '.'));
    options.MapType<DateOnly>(() => new OpenApiSchema
    {
        Type = "string",
        Format = "date"
    });
    options.MapType<TimeOnly>(() => new OpenApiSchema
    {
        Type = "string",
        Format = "time",
        Example = OpenApiAnyFactory.CreateFromJson(DateTime.Now.ToString("HH:mm:ss"))
    });
});

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.Converters.Add(new TimeOnlyJsonConverter());
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
    });

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