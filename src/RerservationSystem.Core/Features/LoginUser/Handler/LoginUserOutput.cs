using RerservationSystem.Core.Shared.Handlers;
using System.Net;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserOutput : IOutput
    {
        public HttpStatusCode StatusCode { get; }

        public string JwtToken { get; } = string.Empty;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        private LoginUserOutput(HttpStatusCode statusCode, string jwtToken)
        {
            StatusCode = statusCode;
            JwtToken = jwtToken;
        }

        private LoginUserOutput(HttpStatusCode statusCode, string jwtToken, IEnumerable<string> errors)
            : this(statusCode, jwtToken)
        {
            Errors = errors;
        }

        public static LoginUserOutput Success(string JwtToken)
            => new(HttpStatusCode.OK, JwtToken);

        public static LoginUserOutput Failure(HttpStatusCode statusCode, IEnumerable<string> errors)
            => new(statusCode, string.Empty, errors);
    }
}
