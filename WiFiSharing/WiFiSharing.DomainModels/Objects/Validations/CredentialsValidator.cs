namespace WiFiSharing.DTOs.Objects.Validations
{
    using FluentValidation;

    public class CredentialsValidator : AbstractValidator<Credentials>
    {
        public CredentialsValidator()
        {
            RuleFor(model => model.Email)
                .NotEmpty()
                .WithMessage("Username cannot be empty");

            RuleFor(model => model.Email)
                .Matches(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,10})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$")
                .WithMessage("Email must be valid");

            RuleFor(model => model.Password)
                .NotEmpty()
                .WithMessage("Password cannot be empty");

            RuleFor(model => model.Password)
                .Length(6, 12)
                .WithMessage("Password must be between 6 and 12 characters");
        }
    }
}
