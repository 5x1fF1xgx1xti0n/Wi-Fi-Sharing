namespace WiFiSharing.BLL.Repositories
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IUserRepository
    {
        Task<PagedList<UserDTO>> GetSegmentedAsync(Filters filters);
        Task<UserDTO> GetAsync(int id);
        Task<UserDTO> GetByEmailAsync(string email);
        Task CreateAsync(UserDTO dto);
        Task UpdateAsync(UserDTO dto);
        Task DeleteAsync(int id);
        Task<string> GetUserPasswordAsync(int id);
    }
}
