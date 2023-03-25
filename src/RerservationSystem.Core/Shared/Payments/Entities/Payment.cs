using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Enums;
using RerservationSystem.Core.Shared.Reservations.Entities;

namespace RerservationSystem.Core.Shared.Payments.Entities
{
    public class Payment : Entity
    {
        public Reservation MyProperty { get; set; }

        public EPaymentMethod Method { get; set; }

        public decimal Value { get; set; }

        public Payment(int id, Reservation myProperty, EPaymentMethod method, decimal value, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            MyProperty = myProperty;
            Method = method;
            Value = value;
        }
    }
}
