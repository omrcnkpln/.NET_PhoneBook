using Contact.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add(UserRequest userAddDto)
        {
            return Ok("basrili");

            return BadRequest("An Error Occured On Controller");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }
    }
}
