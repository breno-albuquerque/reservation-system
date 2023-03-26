using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserHandler : IHandler<RegisterUserInput, RegisterUserOutput>
    {
        public async Task<IOutput> HandleAsync(RegisterUserInput input)
        {
            return new RegisterUserOutput();
        }
    }
}
