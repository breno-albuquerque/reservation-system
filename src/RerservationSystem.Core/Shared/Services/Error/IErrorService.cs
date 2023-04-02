using Flunt.Notifications;

namespace RerservationSystem.Core.Shared.Services.Error
{
    public interface IErrorService
    {
        void AddError(string error);

        void AddErrors(IEnumerable<string> errors);

        void SetNotificationsAsErrors(IEnumerable<Notification> notifications);

        IEnumerable<string> GetErrors();
    }
}
