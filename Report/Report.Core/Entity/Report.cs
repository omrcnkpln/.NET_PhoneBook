using Report.Core.Enums;

namespace Report.Core.Entity
{
    public class Report : BaseEntity
    {
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public ReportStateEnum State { get; set; }
    }
}
