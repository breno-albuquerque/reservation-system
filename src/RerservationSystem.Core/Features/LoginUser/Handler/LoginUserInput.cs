using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserInput : IInput
    {
        public string Email { get; } = string.Empty;

        public string Password { get; } = string.Empty;

        public LoginUserInput(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
