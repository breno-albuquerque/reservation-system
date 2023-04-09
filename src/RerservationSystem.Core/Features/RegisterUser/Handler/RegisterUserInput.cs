using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Roles.Enums;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserInput : IInput
    {
        public string Document { get; } = string.Empty;

        public string Email { get; } = string.Empty;

        public ERole Role { get; }

        public RegisterUserInput(string document, string email, ERole role)
        {
            Document = document;
            Email = email;
            Role = role;
        }
    }
}
