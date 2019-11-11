namespace WiFiSharing.Services
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IOrderService
    {
        Task<PagedList<OrderDTO>> GetSegmented(Filters filters);
        Task<OrderDTO> Get(int userId, int droneId);
        Task Create(OrderDTO dto);
        Task Update(OrderDTO dto);
        Task Delete(int userId, int droneId);
    }
}
