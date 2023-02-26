using Microsoft.AspNetCore.Mvc;

namespace Report.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();

            //var res = await _unitOfService.User.GetAllAsync();

            //return res != null ? Ok(res) : BadRequest();
        }
    }
}
