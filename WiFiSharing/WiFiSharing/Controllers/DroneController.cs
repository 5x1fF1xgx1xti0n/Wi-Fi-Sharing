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
        public async Task<ActionResult<PagedList<DroneDTO>>> GetSegmentedAsync(Filters filters)
        {
            return Ok(await _service.GetSegmentedAsync(filters));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DroneDTO>> GetAsync(int id)
        {
            return Ok(await _service.GetAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(DroneDTO dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(DroneDTO dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}