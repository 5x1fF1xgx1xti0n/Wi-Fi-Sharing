namespace WiFiSharing.Configuration
{
    using Microsoft.IdentityModel.Tokens;
    using System.Text;

    public class AppSettings
    {
        private const string secret = "3r3PB5=sNygC,Q<^";
        public static SymmetricSecurityKey GetSymmetricKey() =>
            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
    }
}
