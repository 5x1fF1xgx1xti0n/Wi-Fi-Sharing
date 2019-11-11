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
        public async Task<ActionResult<PagedList<OrderDTO>>> GetSegmented([FromQuery] Filters filters)
        {
            return Ok(await _service.GetSegmented(filters));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTO>> Get(int userId, int droneId)
        {
            return Ok(await _service.Get(userId, droneId));
        }

        [HttpPost]
        public async Task<ActionResult> Create(OrderDTO dto)
        {
            await _service.Create(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(OrderDTO dto)
        {
            await _service.Create(dto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int userId, int droneId)
        {
            await _service.Delete(userId, droneId);
            return Ok();
        }
    }
}