namespace WiFiSharing.Services
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IDroneService
    {
        Task<PagedList<DroneDTO>> GetSegmented(Filters filters);
        Task<DroneDTO> Get(int id);
        Task Create(DroneDTO dto);
        Task Update(DroneDTO dto);
        Task Delete(int id);
    }
}
