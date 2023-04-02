using RerservationSystem.Core.Features.RegisterUser.Contract;
using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Services.Error;
using RerservationSystem.Core.Shared.Users.Entities;
using RerservationSystem.Core.Shared.Users.Repositories;
using SecureIdentity.Password;
using System.Net;

namespace RerservationSystem.Core.Features.RegisterUser.Handler
{
    public sealed class RegisterUserHandler : IHandler<RegisterUserInput, RegisterUserOutput>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRegisterUserInputContract _inputContract;
        private readonly IErrorService _errorService;

        public RegisterUserHandler(IUserRepository userRepository, IRegisterUserInputContract inputContract, IErrorService errorService)
        {
            _userRepository = userRepository;
            _inputContract = inputContract;
            _errorService = errorService;
        }

        public async Task<RegisterUserOutput> HandleAsync(RegisterUserInput input)
        {
            if (!_inputContract.Validate(input))
            {
                _errorService.SetNotificationsAsErrors(_inputContract.GetNotifications());
                return RegisterUserOutput.Failure(HttpStatusCode.BadRequest);
            }

            var user = new User(input.Email, input.Document, input.Role, default, DateTime.Now, DateTime.Now);

            if (await _userRepository.ExistsAsync(user.Email))
                return RegisterUserOutput.Failure(HttpStatusCode.Conflict);

            var password = GeneratePassword(user);

            var insertion = await _userRepository.CreateUserAsync(user);

            if (!insertion.Success)
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
