using Report.Business.Services;
using Report.Core.Services;

namespace Report.Infrastructure
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IReportService, ReportService>();

            return services;
        }
    }
}
