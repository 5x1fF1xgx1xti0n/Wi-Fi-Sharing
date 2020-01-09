using WiFiSharing.BLL.Repositories;

namespace WiFiSharing.BLL.Services
{
    public class AuthorizationService
    {
        private readonly IUserRepository _repository;

        public AuthorizationService(IUserRepository repository)
        {
            _repository = repository;
        }
    }
}
