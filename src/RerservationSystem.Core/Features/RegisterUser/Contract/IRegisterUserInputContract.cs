using Flunt.Notifications;
using RerservationSystem.Core.Features.RegisterUser.Handler;

namespace RerservationSystem.Core.Features.RegisterUser.Contract
{
    public interface IRegisterUserInputContract
    {
        bool Validate(RegisterUserInput input);

        IEnumerable<Notification> GetNotifications();
    }
}
