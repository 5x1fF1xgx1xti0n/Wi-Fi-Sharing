namespace WiFiSharing.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class DroneController : ControllerBase
    {
        private readonly IDroneService _service;

        public DroneController(IDroneService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<DroneDTO>>> GetSegmented(Filters filters)
        {
            return Ok(await _service.GetSegmented(filters));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DroneDTO>> Get(int id)
        {
            return Ok(await _service.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create(DroneDTO dto)
        {
            await _service.Create(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(DroneDTO dto)
        {
            await _service.Create(dto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}