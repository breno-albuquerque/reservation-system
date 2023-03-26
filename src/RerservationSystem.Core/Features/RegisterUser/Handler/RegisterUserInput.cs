using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Roles.Enums;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserInput : IInput
    {
        public string Document { get; set; }

        public string Email { get; set; }

        public ERole Role { get; set; }

        public string Password { get; set; }

        public RegisterUserInput(string document, string email, ERole role, string password)
        {
            Document = document;
            Email = email;
            Role = role;
            Password = password;
        }
    }
}
