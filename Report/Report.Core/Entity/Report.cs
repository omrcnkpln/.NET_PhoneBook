using Report.Core.Enums;

namespace Report.Core.Entity
{
    public class Report : BaseEntity
    {
        public DateTime RequestDate { get; set; }
        public ReportStateEnum State { get; set; }
    }
}
