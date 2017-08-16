using AutoMapper;
using FluentValidation;
namespace NancyRealWorld
{
    public class LoginVm
    {
        public LoginData User { get; set; }
    }
    public class LoginData
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
    public class LoginDataValidator : AbstractValidator<LoginData> {
		public LoginDataValidator() {
			RuleFor(x => x.Email).NotNull().NotEmpty();
            RuleFor(x => x.Password).NotNull().NotEmpty();
		}
	}
}