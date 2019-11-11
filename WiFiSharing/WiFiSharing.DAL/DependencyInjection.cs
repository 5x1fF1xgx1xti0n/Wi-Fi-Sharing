namespace WiFiSharing.DAL
{
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;
    using WiFiSharing.BLL.Repositories;
    using WiFiSharing.DAL.Profiles;
    using WiFiSharing.DAL.Repositories;

    public static class DependencyInjection
    {
        public static void InjectDataAccessLayerDependencies(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IDroneRepository, DroneRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
