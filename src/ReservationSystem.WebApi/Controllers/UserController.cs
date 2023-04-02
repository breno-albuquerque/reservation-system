using Microsoft.AspNetCore.Mvc;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Handlers;
using ReservationSystem.WebApi.ViewModels.RegisterUser;
using System.Net;

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
            [FromBody] RegisterUserRequest registerUserRequest,
            [FromServices] IHandler<RegisterUserInput, RegisterUserOutput> registerUserHandler
            )
        {
            var input = new RegisterUserInput(registerUserRequest.Document, registerUserRequest.Email, 
                registerUserRequest.Role, registerUserRequest.Password);

            var output = await registerUserHandler.HandleAsync(input);

            var response = new RegisterUserResponse(output.JwtToken);

            return StatusCode((int)output.StatusCode, response);
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
