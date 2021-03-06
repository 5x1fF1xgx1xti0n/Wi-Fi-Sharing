﻿namespace WiFiSharing.DAL.Repositories
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DAL.Entities;
    using WiFiSharing.DAL.Extensions;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    internal class DroneRepository : Repository, IDroneRepository
    {
        public DroneRepository(AppDBContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<PagedList<DroneDTO>> GetSegmented(Filters filters)
        {
            var pagedEntities = await _context.Drones
                            .Search(filters.SearchFilter)
                            .GetOrdered(filters.OrderFilter)
                            .GetPage(filters.PageFilter);

            var page = _mapper.Map<PagedList<Drone>, PagedList<DroneDTO>>(pagedEntities);

            return page;
        }

        public async Task<DroneDTO> Get(int id)
        {
            var entry = await _context.Drones
                .SingleOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Drone, DroneDTO>(entry);
        }

        public async Task Create(DroneDTO dto)
        {
            var entry = _mapper.Map<DroneDTO, Drone>(dto);

            _context.Drones.Add(entry);
            await _context.SaveChangesAsync();
        }

        public async Task Update(DroneDTO dto)
        {
            var entry = await _context.Drones
                .SingleOrDefaultAsync(x => x.Id == dto.Id);

            if (entry == null)
            {
                return;
            }

            entry = _mapper.Map(dto, entry);

            _context.Drones.Update(entry);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entry = await _context.Drones
                .SingleOrDefaultAsync(x => x.Id == id);

            if (entry == null)
            {
                return;
            }

            _context.Drones.Remove(entry);
        }
    }
}
