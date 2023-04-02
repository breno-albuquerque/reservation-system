using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserInput : IInput
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public LoginUserInput(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
