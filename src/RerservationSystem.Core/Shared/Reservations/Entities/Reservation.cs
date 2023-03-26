using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Users.Entities;

namespace RerservationSystem.Core.Shared.Reservations.Entities
{
    public class Reservation : Entity
    {
        public User User { get; set; }

        public Product Service { get; set; }

        public DateTime DateBegin { get; set; }

        public DateTime DateEnd { get; set; }

        public Reservation(int id, User user, Product service, DateTime dateBegin, DateTime dateEnd, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            User = user;
            Service = service;
            DateBegin = dateBegin;
            DateEnd = dateEnd;
        }
    }
}
