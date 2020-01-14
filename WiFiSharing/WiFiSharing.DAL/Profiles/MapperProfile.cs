namespace WiFiSharing.DAL.Profiles
{
    using AutoMapper;
    using WiFiSharing.DAL.Entities;
    using WiFiSharing.DTOs.Filters;
    using WiFiSharing.DTOs.Objects;

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Drone, DroneDTO>()
                .ReverseMap();

            CreateMap<User, UserDTO>()
                .ReverseMap();

            CreateMap<Order, OrderDTO>()
                .ReverseMap();

            CreateMap<RegistrationDTO, UserDTO>()
                .ReverseMap();

            CreateMap(typeof(PagedList<>), typeof(PagedList<>));
        }
    }
}
