using Microsoft.AspNetCore.Mvc;
using RerservationSystem.Core.Features.LoginUser.Handler;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Handlers;
using ReservationSystem.WebApi.Filters;
using ReservationSystem.WebApi.Handlers;
using ReservationSystem.WebApi.ViewModels.LoginUser;
using ReservationSystem.WebApi.ViewModels.RegisterUser;
using System.Net;

namespace ReservationSystem.WebApi.Controllers
{
    [ApiController]
    public sealed class UserController : ControllerBase
    {
        private readonly IResponseHandler _responseHandler;

        public UserController(IResponseHandler responseHandler) 
        {
            _responseHandler = responseHandler;
        }

        [HttpPost("/v1/user/register")]
        [ValidateModel]
        public async Task<ActionResult<RegisterUserResponse>> RegisterUserAsync(
            [FromBody] RegisterUserRequest registerUserRequest,
            [FromServices] IHandler<RegisterUserInput, RegisterUserOutput> registerUserHandler
            )
        {
            var input = new RegisterUserInput(
                registerUserRequest.Document, 
                registerUserRequest.Email, 
                registerUserRequest.Role);

            var output = await registerUserHandler.HandleAsync(input);

            var response = new RegisterUserResponse(output.Password, output.Errors);

            if (output.StatusCode != HttpStatusCode.OK)
                return _responseHandler.Handle(response, output.StatusCode);

            return Created("/v1/user/register", response);
        }

        [HttpPost("/v1/user/login")]
        [ValidateModel]
        public async Task<ActionResult<LoginUserResponse>> LoginUserAsync(
            [FromBody] LoginUserRequest loginUserRequest,
            [FromServices] IHandler<LoginUserInput, LoginUserOutput> loginUserHandler
            )
        {
            var input = new LoginUserInput(
                loginUserRequest.Email,
                loginUserRequest.Password);

            var output = await loginUserHandler.HandleAsync(input);

            var response = new LoginUserResponse(output.JwtToken, output.Errors);

            if (output.StatusCode != HttpStatusCode.OK)
                return _responseHandler.Handle(response, output.StatusCode);

            return Ok(response);
        }
    }
}
