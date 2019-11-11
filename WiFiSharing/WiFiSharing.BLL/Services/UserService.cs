namespace WiFiSharing.BLL.Services
{
    using System.Threading.Tasks;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.Services;

    internal class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedList<UserDTO>> GetSegmented(Filters filters)
        {
            return await _repository.GetSegmented(filters);
        }

        public async Task<UserDTO> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task Create(UserDTO dto)
        {
            await _repository.Create(dto);
        }

        public async Task Update(UserDTO dto)
        {
            await _repository.Update(dto);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
