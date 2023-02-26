using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Report.Core.Repositories;
using Report.Infrastructure.Context;
using Report.Infrastructure.Repositories;

namespace Report.Infrastructure
{
    public static class RepositoryDependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<PhoneBookReportDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
