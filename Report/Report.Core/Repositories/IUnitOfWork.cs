namespace Report.Core.Repositories
{
    public interface IUnitOfWork
    {
        IReportRepository Report { get; }
    }
}
