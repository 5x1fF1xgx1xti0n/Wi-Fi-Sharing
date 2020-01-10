namespace WiFiSharing.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<OrderDTO>>> GetSegmentedAsync([FromQuery] Filters filters)
        {
            return Ok(await _service.GetSegmentedAsync(filters));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTO>> GetAsync(int userId, int droneId)
        {
            return Ok(await _service.GetAsync(userId, droneId));
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(OrderDTO dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(OrderDTO dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync(int userId, int droneId)
        {
            await _service.DeleteAsync(userId, droneId);
            return Ok();
        }
    }
}