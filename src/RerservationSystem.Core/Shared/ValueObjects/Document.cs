using RerservationSystem.Core.Shared.ValueObjects.Base;

namespace RerservationSystem.Core.Shared.ValueObjects
{
    public class Document : ValueObject
    {
        public int Number { get; set; }

        public Document(int number)
        {
            Number = number;
        }
    }
}
