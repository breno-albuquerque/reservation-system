using Flunt.Notifications;

namespace RerservationSystem.Core.Shared.Services.Error
{
    public class ErrorService : IErrorService
    {
        private IList<string> _errors = new List<string>();

        public void AddError(string error)
        {
            if (string.IsNullOrEmpty(error))
                return;

            _errors.Add(error);
        }

        public void AddErrors(IEnumerable<string> errors)
        {
            foreach (var error in errors)
                if (!string.IsNullOrEmpty(error))
                    _errors.Add(error);
        }

        public void SetNotificationsAsErrors(IEnumerable<Notification> notifications)
        {
            _errors = notifications.Select(n => n.Key).ToList();
        }

        public IEnumerable<string> GetErrors()
            => _errors;
    }
}
