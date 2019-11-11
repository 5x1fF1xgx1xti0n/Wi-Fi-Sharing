namespace WiFiSharing.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using WiFiSharing.BLL;
    using WiFiSharing.DAL;

    public static class DependencyInjection
    {
        public static void InjectDependencies(this IServiceCollection services)
        {
            services.InjectDataAccessLayerDependencies();
            services.InjectBusinessLogicLayerDependencies();
        }
    }
}
