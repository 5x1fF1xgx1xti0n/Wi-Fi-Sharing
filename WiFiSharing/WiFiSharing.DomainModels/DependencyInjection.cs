namespace WiFiSharing.DTOs
{
    using FluentValidation;
    using Microsoft.Extensions.DependencyInjection;
    using WiFiSharing.DTOs.Objects;
    using WiFiSharing.DTOs.Objects.Validations;

    public static class DependencyInjection
    {
        public static void InjectValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Credentials>, CredentialsValidator>();
            services.AddTransient<IValidator<RegistrationDTO>, RegistrationValidator>();
        }
    }
}
