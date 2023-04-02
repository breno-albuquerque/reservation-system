using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserInput : IInput
    {
        public string Email { get; }

        public string Password { get; }

        public LoginUserInput(string? email, string? password)
        {
            Email = email ?? string.Empty;
            Password = password ?? string.Empty;
        }
    }
}
