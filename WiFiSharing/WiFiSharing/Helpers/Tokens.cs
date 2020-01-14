namespace WiFiSharing.API.Helpers
{
    using Newtonsoft.Json;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using WiFiSharing.Common.Models;
    using WiFiSharing.Services;

    public class Tokens
    {
        public static async Task<string> GenerateJwt(ClaimsIdentity identity, IAuthService authService, string userName, JwtOptions jwtOptions, JsonSerializerSettings serializerSettings)
        {
            var response = new
            {
                id = identity.Claims.Single(c => c.Type == "id").Value,
                auth_token = await authService.GenerateEncodedToken(userName, identity),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return JsonConvert.SerializeObject(response, serializerSettings);
        }
    }
}
