namespace Report.Core.Services
{
    public interface IReportService
    {
        Task<IList<Entity.Report>> GetAllAsync();
    }
}
