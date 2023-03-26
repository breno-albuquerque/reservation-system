using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Services.JwtToken;
using RerservationSystem.Core.Shared.Users.Entities;
using RerservationSystem.Core.Shared.Users.Repositories;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserHandler : IHandler<RegisterUserInput, RegisterUserOutput>
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public RegisterUserHandler(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<RegisterUserOutput> HandleAsync(RegisterUserInput input)
        {
            var user = new User(DateTime.Now, DateTime.Now, input.Document, input.Email, input.Role, input.Password);

            var result = await _userRepository.CreateUserAsync(user);

            if (result == 0)
                return RegisterUserOutput.Failure();

            var token = _tokenService.GenerateToken(user);

            return RegisterUserOutput.Success(token);
        }
    }
}
