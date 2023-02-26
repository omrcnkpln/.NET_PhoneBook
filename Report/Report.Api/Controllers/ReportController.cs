using Microsoft.AspNetCore.Mvc;
using Report.Core.Services;

namespace Report.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = _reportService.GetAllAsync();

            return res != null ? Ok(res) : BadRequest();
        }
    }
}
