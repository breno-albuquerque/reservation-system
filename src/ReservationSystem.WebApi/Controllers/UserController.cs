using Microsoft.AspNetCore.Mvc;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Handlers;
using ReservationSystem.WebApi.Transport;

namespace ReservationSystem.WebApi.Controllers
{
    [ApiController]
    public sealed class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [HttpPost("/v1/user")]
        public async Task<ActionResult<RegisterUserOutput>> RegisterUserAsync(
            [FromBody] RegisterUserView registerUserView,
            [FromServices] IHandler<RegisterUserInput, RegisterUserOutput> registerUserHandler
            )
        {
            var input = new RegisterUserInput(registerUserView.Document, registerUserView.Email, 
                registerUserView.Role, registerUserView.Password);

            var output = await registerUserHandler.HandleAsync(input);

            return Ok(output);
        }

        [HttpGet("/v1/user")]
        public async Task<ActionResult<LoginUserOutput>> LoginUserAsync()
        {
            var input = new LoginUserInput();

            //  var output = await _loginUserHandler.HandleAsync(input);

            return Ok();
        }
    }
}
