namespace WiFiSharing.Services
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    public interface IAuthService
    {
        Task<string> GenerateEncodedToken(string email, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string email, int id);
    }
}
