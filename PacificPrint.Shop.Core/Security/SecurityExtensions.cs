using PacificPrint.Shop.Core.Common_Security;
using PacificPrint.Shop.Core.Security;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SecurityExtensions
    {
        public static IServiceCollection AddCurrentUser(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<ICurrentUser, DefaultCurrentUser>();

            return services;
        }
    }
}
