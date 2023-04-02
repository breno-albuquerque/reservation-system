using Microsoft.AspNetCore.Mvc;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Handlers;
using RerservationSystem.Core.Shared.Services.Error;
using ReservationSystem.WebApi.ViewModels.LoginUser;
using ReservationSystem.WebApi.ViewModels.RegisterUser;

namespace ReservationSystem.WebApi.Controllers
{
    [ApiController]
    public sealed class UserController : ControllerBase
    {
        private readonly ErrorService _errorService;

        public UserController(ErrorService errorService) 
        {
            _errorService = errorService;
        }

        [HttpPost("/v1/user/register")]
        public async Task<ActionResult<RegisterUserOutput>> RegisterUserAsync(
            [FromBody] RegisterUserRequest registerUserRequest,
            [FromServices] IHandler<RegisterUserInput, RegisterUserOutput> registerUserHandler
            )
        {
            var input = new RegisterUserInput(
                registerUserRequest.Document, 
                registerUserRequest.Email, 
                registerUserRequest.Role);

            var output = await registerUserHandler.HandleAsync(input);

            var response = new RegisterUserResponse(output.Password, _errorService.Errors);

            return StatusCode((int)output.StatusCode, response);
        }

        [HttpPost("/v1/user/login")]
        public async Task<ActionResult<LoginUserOutput>> LoginUserAsync(
            [FromBody] LoginUserRequest loginUserRequest,
            [FromServices] IHandler<LoginUserInput, LoginUserOutput> loginUserHandler
            )
        {
            var input = new LoginUserInput(
                loginUserRequest.Email,
                loginUserRequest.Password
                );

            var output = await loginUserHandler.HandleAsync(input);

            var response = new LoginUserResponse(output.JwtToken, _errorService.Errors);

            return StatusCode((int)output.StatusCode, response);
        }
    }
}
