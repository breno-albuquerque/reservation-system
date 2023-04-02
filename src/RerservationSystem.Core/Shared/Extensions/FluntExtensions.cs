using Flunt.Validations;

namespace RerservationSystem.Core.Shared.Extensions
{
    public static class FluntExtensions
    {
        public static void IsEnum<T>(this Contract<T> contract, Enum enumValue, int? value, string key, string message = "Must be inside role enum range")
        {
            Type type = enumValue.GetType();

            if (value <= Enum.GetNames(type).Length && value > 0)
                return;

            contract.AddNotification(key, message);
        }
    }
}
