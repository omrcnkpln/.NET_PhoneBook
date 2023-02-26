using Report.Core.Repositories;
using Report.Infrastructure.Context;

namespace Report.Infrastructure.Repositories
{
    public class ReportRepository : GenericRepository<Core.Entity.Report>, IReportRepository
    {
        public ReportRepository(PhoneBookReportDbContext context)
             : base(context)
        { }
    }
}
