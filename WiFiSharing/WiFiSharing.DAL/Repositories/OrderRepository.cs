namespace WiFiSharing.DAL.Repositories
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DAL.Entities;
    using WiFiSharing.DAL.Extensions;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    internal class OrderRepository : Repository, IOrderRepository
    {
        public OrderRepository(AppDBContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<PagedList<OrderDTO>> GetSegmented(Filters filters)
        {
            var pagedEntities = await _context.Orders
                            .Search(filters.SearchFilter)
                            .GetOrdered(filters.OrderFilter)
                            .GetPage(filters.PageFilter);

            var page = _mapper.Map<PagedList<Order>, PagedList<OrderDTO>>(pagedEntities);

            return page;
        }

        public async Task<OrderDTO> Get(int userId, int droneId)
        {
            var entry = await _context.Orders
                .SingleOrDefaultAsync(x => x.UserId == userId && x.DroneId == droneId);

            return _mapper.Map<Order, OrderDTO>(entry);
        }

        public async Task Create(OrderDTO dto)
        {
            try
            {
                var entry = _mapper.Map<OrderDTO, Order>(dto);

                _context.Orders.Add(entry);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Update(OrderDTO dto)
        {            
            try
            {
                var entry = _context.Orders
                                .SingleOrDefault(x => x.UserId == dto.UserId && x.DroneId == dto.DroneId);

                if (entry == null)
                {
                    return;
                }

                entry = _mapper.Map(dto, entry);

                _context.Orders.Update(entry);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Delete(int userId, int droneId)
        {
            try
            {
                var entry = await _context.Orders
                    .SingleOrDefaultAsync(x => x.UserId == userId && x.DroneId == droneId);

                if (entry == null)
                {
                    return;
                }

                _context.Orders.Remove(entry);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
