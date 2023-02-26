using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Infrastructure
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            //services.AddScoped<IUnitOfService, UnitOfService>();

            //services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
