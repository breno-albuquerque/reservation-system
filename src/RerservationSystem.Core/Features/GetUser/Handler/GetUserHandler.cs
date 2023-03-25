using RerservationSystem.Core.Shared.Handlers;

namespace RerservationSystem.Core.Features.CreateUser.Handler
{
    public class GetUserHandler : IHandler<GetUserInput, GetUserOutput>
    {
        public GetUserHandler()
        {
            
        }

        public async Task<IOutput> HandleAsync(GetUserInput input)
        {
            return new GetUserOutput();
        }
    }
}
