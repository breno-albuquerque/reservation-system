using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserHandler : IHandler<LoginUserInput, LoginUserOutput>
    {
        public LoginUserHandler()
        {

        }

        public async Task<LoginUserOutput> HandleAsync(LoginUserInput input)
        {
            return new LoginUserOutput();
        }
    }
}
