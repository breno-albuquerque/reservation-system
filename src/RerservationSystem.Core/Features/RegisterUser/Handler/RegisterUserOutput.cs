using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserOutput : IOutput
    {
        public bool Success { get; set; }

        public RegisterUserOutput(bool success)
        {
            Success = success;
        }
    }
}
