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

        public async Task<PagedList<OrderDTO>> GetSegmentedAsync(Filters filters)
        {
            return await _repository.GetSegmentedAsync(filters);
        }

        public async Task<OrderDTO> GetAsync(int userId, int droneId)
        {
            return await _repository.GetAsync(userId, droneId);
        }

        public async Task CreateAsync(OrderDTO dto)
        {
            await _repository.CreateAsync(dto);
        }

        public async Task UpdateAsync(OrderDTO dto)
        {
            await _repository.UpdateAsync(dto);
        }

        public async Task DeleteAsync(int userId, int droneId)
        {
            await _repository.DeleteAsync(userId, droneId);
        }
    }
}
