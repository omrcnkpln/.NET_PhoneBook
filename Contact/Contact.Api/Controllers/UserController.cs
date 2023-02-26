using Contact.Core.Requests;
using Contact.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfService _unitOfService;
        public UserController(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _unitOfService.User.GetAllAsync();

            return res != null ? Ok(res) : BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserRequest userAddDto)
        {
            var res = await _unitOfService.User.AddAsync(userAddDto);

            return res != false ? Ok(res) : BadRequest("An Error Occured On Controller");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }
    }
}
