namespace WiFiSharing.DTOs.Objects
{
    using FluentValidation.Attributes;
    using WiFiSharing.DTOs.Objects.Validations;

    [Validator(typeof(CredentialsValidator))]
    public class Credentials
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
