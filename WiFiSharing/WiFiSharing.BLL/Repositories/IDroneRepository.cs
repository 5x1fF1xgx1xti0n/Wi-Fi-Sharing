namespace WiFiSharing.BLL.Repositories
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IDroneRepository
    {
        Task<PagedList<DroneDTO>> GetSegmented(Filters filters);
        Task<DroneDTO> Get(int id);
        Task Create(DroneDTO dto);
        Task Update(DroneDTO dto);
        Task Delete(int id);
    }
}
