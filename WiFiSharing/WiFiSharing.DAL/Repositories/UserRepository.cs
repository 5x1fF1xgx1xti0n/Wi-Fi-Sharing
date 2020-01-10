namespace WiFiSharing.DAL.Repositories
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DAL.Entities;
    using WiFiSharing.DAL.Extensions;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    internal class UserRepository : Repository, IUserRepository
    {
        public UserRepository(AppDBContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<PagedList<UserDTO>> GetSegmentedAsync(Filters filters)
        {
            var pagedEntities = await _context.Users
                .AsNoTracking()
                .Search(filters.SearchFilter)
                .GetOrdered(filters.OrderFilter)
                .GetPage(filters.PageFilter);

            var page = _mapper.Map<PagedList<User>, PagedList<UserDTO>>(pagedEntities);

            return page;
        }

        public async Task<UserDTO> GetAsync(int id)
        {
            var entry = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<User, UserDTO>(entry);
        }

        public async Task<UserDTO> GetByEmailAsync(string email)
        {
            var entry = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Email == email);

            return _mapper.Map<User, UserDTO>(entry);
        }

        public async Task CreateAsync(UserDTO dto)
        {
            var entry = _mapper.Map<UserDTO, User>(dto);

            _context.Users.Add(entry);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserDTO dto)
        {
            var entry = _context.Users
                .SingleOrDefault(x => x.Id == dto.Id);

            if (entry == null)
            {
                return;
            }

            entry = _mapper.Map(dto, entry);

            _context.Users.Update(entry);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entry = await _context.Users
                .SingleOrDefaultAsync(x => x.Id == id);

            if (entry == null)
            {
                return;
            }

            _context.Users.Remove(entry);
            await _context.SaveChangesAsync();
        }

        public async Task<string> GetUserPasswordAsync(int id)
        {
            var entry = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);

            return entry.Password;
        }
    }
}
