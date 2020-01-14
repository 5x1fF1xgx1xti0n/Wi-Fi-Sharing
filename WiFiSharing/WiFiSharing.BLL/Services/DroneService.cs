namespace WiFiSharing.BLL.Services
{
    using System.Threading.Tasks;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.Services;

    internal class DroneService : IDroneService
    {
        private readonly IDroneRepository _repository;

        public DroneService(IDroneRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedList<DroneDTO>> GetSegmentedAsync(Filters filters)
        {
            return await _repository.GetSegmentedAsync(filters);
        }

        public async Task<DroneDTO> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task CreateAsync(DroneDTO dto)
        {
            await _repository.CreateAsync(dto);
        }

        public async Task UpdateAsync(DroneDTO dto)
        {
            await _repository.UpdateAsync(dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
