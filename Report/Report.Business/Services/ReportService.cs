using Report.Core.Repositories;
using Report.Core.Services;

namespace Report.Business.Services
{
    public class ReportService : IReportService
    {
        private IUnitOfWork _unitOfWork;

        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<Core.Entity.Report>> GetAllAsync()
        {
            try
            {
                bool grpcRes = true;

                //if(grpcRes == true)
                //{
                var newReport = new Core.Entity.Report()
                {
                    State = Core.Enums.ReportStateEnum.DONE,
                };

                await _unitOfWork.Report.AddAsync(newReport);

                return new List<Core.Entity.Report>();
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
