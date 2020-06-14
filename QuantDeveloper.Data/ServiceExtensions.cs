using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuantDeveloper.Data.Implementation;
using QuantDeveloper.Data.Interfaces;
using QuantDeveloper.Data.Models;

namespace QuantDeveloper.Data
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDataLibraries(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryFactory, RepositoryFactory>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddScoped<TectoroContext, TectoroContext>();
            return services;
        }
    }
}
