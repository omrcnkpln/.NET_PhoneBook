using Contact.Service.Abstract;
using Contact.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Contact.Service
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfService, UnitOfService>();

            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
