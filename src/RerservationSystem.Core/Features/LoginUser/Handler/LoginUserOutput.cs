using RerservationSystem.Core.Shared.Handlers;
using System.Net;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserOutput : IOutput
    {
        public HttpStatusCode StatusCode { get; }

        public string? JwtToken { get; }

        private LoginUserOutput(HttpStatusCode statusCode, string? jwtToken)
        {
            StatusCode = statusCode;
            JwtToken = jwtToken;
        }

        public static LoginUserOutput Success(string JwtToken)
            => new(HttpStatusCode.OK, JwtToken);

        public static LoginUserOutput Failure(HttpStatusCode statusCode)
            => new(statusCode, default);
    }
}
