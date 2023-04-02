using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Services.JwtToken;
using RerservationSystem.Core.Shared.Users.Repositories;
using SecureIdentity.Password;
using System.Net;

namespace RerservationSystem.Core.Features.LoginUser.Handler
{
    public sealed class LoginUserHandler : IHandler<LoginUserInput, LoginUserOutput>
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public LoginUserHandler(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<LoginUserOutput> HandleAsync(LoginUserInput input)
        {
            var user = await _userRepository.GetAsync(input.Email);

            if (!PasswordHasher.Verify(user.PasswordHash, input.Password))
                return LoginUserOutput.Failure(HttpStatusCode.Unauthorized);

            var token = _tokenService.GenerateToken(user);

            return LoginUserOutput.Success(token);
        }
    }
}
