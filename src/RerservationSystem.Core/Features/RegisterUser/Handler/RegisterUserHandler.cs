using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Users.Entities;
using RerservationSystem.Core.Shared.Users.Repositories;
using SecureIdentity.Password;
using System.Net;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserHandler : IHandler<RegisterUserInput, RegisterUserOutput>
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<RegisterUserOutput> HandleAsync(RegisterUserInput input)
        {
            var user = new User(input.Email, input.Document, input.Role, default, DateTime.Now, DateTime.Now);

            if (await _userRepository.ExistsAsync(user.Email))
                return RegisterUserOutput.Failure(HttpStatusCode.Conflict);

            var password = GeneratePassword(user);

            var result = await _userRepository.CreateUserAsync(user);

            if (result == 0)
                return RegisterUserOutput.Failure(HttpStatusCode.InternalServerError);

            //  TO-DO: Enviar senha por email
            return RegisterUserOutput.Success(password);
        }

        private static string GeneratePassword(User user)
        {
            var password = PasswordGenerator.Generate();
            user.SetPasswordHash(PasswordHasher.Hash(password));

            return password;
        }
    }
}
