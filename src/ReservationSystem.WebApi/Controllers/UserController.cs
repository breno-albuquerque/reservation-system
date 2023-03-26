using Microsoft.AspNetCore.Mvc;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Handlers;

namespace ReservationSystem.WebApi.Controllers
{
    [ApiController]
    public sealed class UserController : ControllerBase
    {
        private readonly IHandler<RegisterUserInput, RegisterUserOutput> _registerUserHandler;
        private readonly IHandler<LoginUserInput, LoginUserOutput> _loginUserHandler;

        public UserController(
            IHandler<RegisterUserInput, RegisterUserOutput> createUserHandler,
            IHandler<LoginUserInput, LoginUserOutput> loginUserHandler
            )
        {
            _registerUserHandler = createUserHandler;
            _loginUserHandler = loginUserHandler;
        }

        [HttpPost("/v1/user")]
        public async Task<ActionResult<RegisterUserOutput>> RegisterUserAsync()
        {
            var input = new RegisterUserInput();

            var output = await _registerUserHandler.HandleAsync(input);

            return Ok(output);
        }

        [HttpGet("/v1/user")]
        public async Task<ActionResult<LoginUserOutput>> LoginUserAsync() 
        {
            var input = new LoginUserInput();

            var output = await _loginUserHandler.HandleAsync(input);

            return Ok(output);
        }
    }
}
