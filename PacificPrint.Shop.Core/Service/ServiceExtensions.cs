using Microsoft.Extensions.DependencyInjection;
using PacificPrint.Shop.Core.Contract;
using PacificPrint.Shop.Core.Service;

namespace PacificPrint.Shop.Core.Service
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
