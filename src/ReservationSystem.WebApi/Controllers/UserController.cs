using Microsoft.AspNetCore.Mvc;
using RerservationSystem.Core.Features.CreateUser.Handler;
using RerservationSystem.Core.Shared.Handlers;

namespace ReservationSystem.WebApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IHandler<GetUserInput, GetUserOutput> _getUserHandler;

        public UserController(
            IHandler<GetUserInput, GetUserOutput> getUserHandler)
        {
            _getUserHandler = getUserHandler;
        }

        [HttpGet("/users")]
        public async Task<ActionResult<GetUserOutput>> GetUser() 
        {
            var input = new GetUserInput();

            var output = await _getUserHandler.HandleAsync(input);

            return Ok(output);
        }
    }
}
