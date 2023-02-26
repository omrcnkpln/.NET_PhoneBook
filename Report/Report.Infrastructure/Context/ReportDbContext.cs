using Microsoft.EntityFrameworkCore;

namespace Report.Infrastructure.Context
{
    public class PhoneBookReportDbContext : DbContext
    {
        public DbSet<Core.Entity.Report>? Reports { get; set; }

        public PhoneBookReportDbContext(DbContextOptions<PhoneBookReportDbContext> options)
         : base(options)
        {
        }
    }
}
