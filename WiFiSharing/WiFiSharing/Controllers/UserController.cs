namespace WiFiSharing.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<UserDTO>>> GetSegmented([FromQuery] Filters filters)
        {
            return Ok(await _service.GetSegmentedAsync(filters));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            return Ok(await _service.GetAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserDTO dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(UserDTO dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}