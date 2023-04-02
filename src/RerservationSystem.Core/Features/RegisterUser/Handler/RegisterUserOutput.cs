using RerservationSystem.Core.Shared.Handlers;
using System.Net;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserOutput : IOutput
    {
        public HttpStatusCode StatusCode { get; }

        public string? Password { get; }

        private RegisterUserOutput(HttpStatusCode statusCode, string? password)
        {
            StatusCode = statusCode;
            Password = password;
        }

        public static RegisterUserOutput Success(string password) => new(HttpStatusCode.Created, password);

        public static RegisterUserOutput Failure(HttpStatusCode status) => new(status, default);
    }
}
