namespace WiFiSharing.BLL.Services
{
    using System.Threading.Tasks;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.Services;

    internal class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedList<OrderDTO>> GetSegmented(Filters filters)
        {
            return await _repository.GetSegmented(filters);
        }

        public async Task<OrderDTO> Get(int userId, int droneId)
        {
            return await _repository.Get(userId, droneId);
        }

        public async Task Create(OrderDTO dto)
        {
            await _repository.Create(dto);
        }

        public async Task Update(OrderDTO dto)
        {
            await _repository.Update(dto);
        }

        public async Task Delete(int userId, int droneId)
        {
            await _repository.Delete(userId, droneId);
        }
    }
}
