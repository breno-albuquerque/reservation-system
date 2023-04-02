using Flunt.Localization;
using Flunt.Notifications;
using Flunt.Validations;
using RerservationSystem.Core.Features.RegisterUser.Handler;
using RerservationSystem.Core.Shared.Roles.Enums;

namespace RerservationSystem.Core.Features.RegisterUser.Contract
{
    public class RegisterUserInputContract : Contract<RegisterUserInput>, IRegisterUserInputContract
    {
        private const string ValidEmailKey = "Email must be valid";
        private const string DocumentDigitsKey = "Document must contain only digits";
        private const string DocumentLengthKey = "Document length must match 11";
        private const string RoleEnumRangeKey = "Role must be inside enum range";

        public bool Validate(RegisterUserInput input)
        {
            Requires()
                .IsEmail(input.Email, ValidEmailKey);

            Requires()
                .Matches(input.Document, FluntRegexPatterns.OnlyNumbersPattern, DocumentDigitsKey)
                .AreEquals(input.Document.Length, 11, DocumentLengthKey);

            Requires()
                .IsBetween((int)input.Role, 0, Enum.GetNames<ERole>().Length, RoleEnumRangeKey);

            return IsValid;
        }

        public IEnumerable<Notification> GetNotifications() => Notifications;
    }
}
