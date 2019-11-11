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

        public async Task<PagedList<DroneDTO>> GetSegmented(Filters filters)
        {
            return await _repository.GetSegmented(filters);
        }

        public async Task<DroneDTO> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task Create(DroneDTO dto)
        {
            await _repository.Create(dto);
        }

        public async Task Update(DroneDTO dto)
        {
            await _repository.Update(dto);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
