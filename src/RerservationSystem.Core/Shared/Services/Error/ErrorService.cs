namespace RerservationSystem.Core.Shared.Services.Error
{
    public class ErrorService
    {
        private readonly IList<string> _errors = new List<string>();

        public IReadOnlyCollection<string> Errors => _errors.ToList();

        public void AddError(string error)
        {
            if (string.IsNullOrEmpty(error))
                return;

            _errors.Add(error);
        }

        public void AddErrors(IList<string> errors)
        {
            foreach (var error in errors)
                if (!string.IsNullOrEmpty(error))
                    _errors.Add(error);
        }
    }
}
