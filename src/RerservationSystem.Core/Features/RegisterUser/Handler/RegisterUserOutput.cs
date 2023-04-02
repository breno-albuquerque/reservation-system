using RerservationSystem.Core.Shared.Handlers;
using System.Net;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserOutput : IOutput
    {
        public HttpStatusCode StatusCode { get; private set; }

        public string JwtToken { get; private set; }

        private RegisterUserOutput(HttpStatusCode statusCode, string jwtToken)
        {
            StatusCode = statusCode;
            JwtToken = jwtToken;
        }

        public static RegisterUserOutput Success(string jwtToken) => new(HttpStatusCode.Created, jwtToken);

        public static RegisterUserOutput Failure(HttpStatusCode status) => new(status, default);
    }
}
