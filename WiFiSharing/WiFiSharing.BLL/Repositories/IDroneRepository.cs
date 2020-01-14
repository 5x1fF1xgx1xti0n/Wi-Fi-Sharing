namespace WiFiSharing.BLL.Repositories
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IDroneRepository
    {
        Task<PagedList<DroneDTO>> GetSegmentedAsync(Filters filters);
        Task<DroneDTO> GetAsync(int id);
        Task CreateAsync(DroneDTO dto);
        Task UpdateAsync(DroneDTO dto);
        Task DeleteAsync(int id);
    }
}
