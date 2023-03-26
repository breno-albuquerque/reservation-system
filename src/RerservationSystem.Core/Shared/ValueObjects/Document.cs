using RerservationSystem.Core.Shared.ValueObjects.Base;

namespace RerservationSystem.Core.Shared.ValueObjects
{
    public class Document : ValueObject
    {
        public long Number { get; set; }

        public Document(long number)
        {
            Number = number;
        }
    }
}
