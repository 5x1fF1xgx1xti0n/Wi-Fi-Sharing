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

        public async Task<PagedList<UserDTO>> GetSegmentedAsync(Filters filters)
        {
            return await _repository.GetSegmentedAsync(filters);
        }

        public async Task<UserDTO> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<UserDTO> GetByEmailAsync(string email)
        {
            return await _repository.GetByEmailAsync(email);
        }

        public async Task CreateAsync(UserDTO dto)
        {
            await _repository.CreateAsync(dto);
        }

        public async Task UpdateAsync(UserDTO dto)
        {
            await _repository.UpdateAsync(dto);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<bool> CheckCredentialsAsync(Credentials credentials)
        {
            var user = await _repository.GetByEmailAsync(credentials.Email);
            return await _repository.GetUserPasswordAsync(user.Id) == credentials.Password;
        }
    }
}
