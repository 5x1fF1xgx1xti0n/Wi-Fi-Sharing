namespace WiFiSharing.DTOs.Objects.Validations
{
    using FluentValidation;

    public class RegistrationValidator : AbstractValidator<RegistrationDTO>
    {
        public RegistrationValidator()
        {
            RuleFor(model => model.Email)
                .NotEmpty()
                .WithMessage("Email cannot be empty");

            RuleFor(model => model.Email)
                .Matches(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,10})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$")
                .WithMessage("Email must be valid");

            RuleFor(model => model.FirstName)
                .NotEmpty()
                .WithMessage("First name cannot be empty");

            RuleFor(model => model.LastName)
                .NotEmpty()
                .WithMessage("Last name cannot be empty");

            RuleFor(model => model.Phone)
                .NotEmpty()
                .WithMessage("Phone cannot be empty");

            RuleFor(model => model.Phone)
                .Matches(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$")
                .WithMessage("Phone must be valid");

            RuleFor(model => model.PassportCode)
                .NotEmpty()
                .WithMessage("Passport code cannot be empty");

            RuleFor(model => model.Password)
                .NotEmpty()
                .WithMessage("Password cannot be empty");

            RuleFor(model => model.Password)
                .Length(6, 12)
                .WithMessage("Password must be between 6 and 12 characters");
        }
    }
}
