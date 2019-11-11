using Microsoft.Extensions.DependencyInjection;
using WiFiSharing.BLL.Services;
using WiFiSharing.Services;

namespace WiFiSharing.BLL
{
    public static class DependencyInjection
    {
        public static void InjectBusinessLogicLayerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDroneService, DroneService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}
