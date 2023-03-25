using RerservationSystem.Core.Shared.ValueObjects.Base;

namespace RerservationSystem.Core.Shared.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; set; }

        public Email(string address)
        {
            Address = address;
        }
    }
}
