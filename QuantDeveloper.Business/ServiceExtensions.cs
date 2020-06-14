using Microsoft.Extensions.DependencyInjection;
using QuantDeveloper.Business.Interfaces;
using QuantDeveloper.Data;
using QuantDeveloper.Data.Implementation;

namespace QuantDeveloper.Business
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBusinessLibraries(this IServiceCollection services)
        {
            services.AddScoped<IUsersService, UsersService>();
            services.AddDataLibraries();
            return services;
        }
    }
}
