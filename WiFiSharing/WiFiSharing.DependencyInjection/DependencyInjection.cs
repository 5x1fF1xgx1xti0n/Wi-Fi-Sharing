namespace WiFiSharing.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using WiFiSharing.BLL;
    using WiFiSharing.DAL;
    using WiFiSharing.DTOs;

    public static class DependencyInjection
    {
        public static void InjectDependencies(this IServiceCollection services)
        {
            services.InjectDataAccessLayerDependencies();
            services.InjectBusinessLogicLayerDependencies();
            services.InjectValidators();
        }
    }
}
