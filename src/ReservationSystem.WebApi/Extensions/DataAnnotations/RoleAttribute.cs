using RerservationSystem.Core.Shared.Roles.Enums;
using System.ComponentModel.DataAnnotations;

namespace ReservationSystem.WebApi.Extensions.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
        AllowMultiple = false)]
    public sealed class RoleAttribute : DataTypeAttribute
    {
        public RoleAttribute() : base("Role")
        {
        }

        public override bool IsValid(object? value)
        {
            if (value == null)
                return true;

            if ((int)value >= Enum.GetNames(typeof(ERole)).Length || (int)value < 0)
                return false;

            return true;
        }
    }
}
