using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Users.Entities;
using RerservationSystem.Core.Shared.Users.Repositories;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserHandler : IHandler<RegisterUserInput, RegisterUserOutput>
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IOutput> HandleAsync(RegisterUserInput input)
        {
            var user = new User(DateTime.Now, DateTime.Now, input.Document, input.Email, input.Role, input.Password);

            var result = await _userRepository.CreateUserAsync(user);

            var output = new RegisterUserOutput(true);

            return output;
        }
    }
}
