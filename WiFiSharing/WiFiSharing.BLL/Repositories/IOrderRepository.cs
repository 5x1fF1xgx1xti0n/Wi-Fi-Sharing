namespace WiFiSharing.BLL.Repositories
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IOrderRepository
    {
        Task<PagedList<OrderDTO>> GetSegmented(Filters filters);
        Task<OrderDTO> Get(int userId, int droneId);
        Task Create(OrderDTO dto);
        Task Update(OrderDTO dto);
        Task Delete(int userId, int droneId);
    }
}
