using System.ComponentModel.DataAnnotations;

namespace ReservationSystem.WebApi.Attributes.DataType
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
        AllowMultiple = false)]
    public sealed class CpfAttribute : DataTypeAttribute
    {
        public CpfAttribute() : base("Cpf") { }

        public override bool IsValid(object? value)
        {
            if (value == null)
                return true;

            if (value is not string valueAsString)
                return false;

            if (IsNumeric(valueAsString) == false)
                return false;

            return valueAsString.Length == 11;
        }

        private static bool IsNumeric(string s) => long.TryParse(s, out _);
    }
}
