using RerservationSystem.Core.Shared.Handlers;
using System.Net;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserOutput : IOutput
    {
        public HttpStatusCode StatusCode { get; }

        public string? Password { get; }

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        private RegisterUserOutput(HttpStatusCode statusCode, string? password)
        {
            StatusCode = statusCode;
            Password = password;
        }

        private RegisterUserOutput(HttpStatusCode statusCode, string? password, IEnumerable<string> errors)
            : this(statusCode, password)
        {
            Errors = errors;
        }

        public static RegisterUserOutput Success(string password) 
            => new(HttpStatusCode.Created, password);

        public static RegisterUserOutput Failure(HttpStatusCode status, IEnumerable<string> errors) 
            => new(status, default, errors);
    }
}
