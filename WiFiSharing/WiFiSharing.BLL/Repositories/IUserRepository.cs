namespace WiFiSharing.BLL.Repositories
{
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public interface IUserRepository
    {
        Task<PagedList<UserDTO>> GetSegmented(Filters filters);
        Task<UserDTO> Get(int id);
        Task Create(UserDTO dto);
        Task Update(UserDTO dto);
        Task Delete(int id);
    }
}
