using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserOutput : IOutput
    {
        public bool WasSucceded { get; private set; }

        public string JwtToken { get; private set; }

        private RegisterUserOutput(bool wasSucceded, string jwtToken)
        {
            WasSucceded = wasSucceded;
            JwtToken = jwtToken;
        }

        public static RegisterUserOutput Success(string jwtToken) => new(true, jwtToken);

        public static RegisterUserOutput Failure() => new(false, default);
    }
}
