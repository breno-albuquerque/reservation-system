using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Roles.Enums;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserInput : IInput
    {
        public string Document { get; }

        public string Email { get; }

        public ERole Role { get; }

        public RegisterUserInput(string? document, string? email, ERole role)
        {
            Document = document ?? string.Empty;
            Email = email ?? string.Empty;
            Role = role;
        }
    }
}
