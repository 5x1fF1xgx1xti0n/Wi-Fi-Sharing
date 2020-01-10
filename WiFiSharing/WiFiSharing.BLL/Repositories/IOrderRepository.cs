namespace WiFiSharing.BLL.Repositories
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IOrderRepository
    {
        Task<PagedList<OrderDTO>> GetSegmentedAsync(Filters filters);
        Task<OrderDTO> GetAsync(int userId, int droneId);
        Task CreateAsync(OrderDTO dto);
        Task UpdateAsync(OrderDTO dto);
        Task DeleteAsync(int userId, int droneId);
    }
}
