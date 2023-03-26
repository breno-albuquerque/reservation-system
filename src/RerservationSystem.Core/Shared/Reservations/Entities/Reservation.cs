using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Products.Entities;
using RerservationSystem.Core.Shared.Users.Entities;

namespace RerservationSystem.Core.Shared.Reservations.Entities
{
    public class Reservation : Entity
    {
        public User User { get; set; }

        public Product Product { get; set; }

        public DateTime DateBegin { get; set; }

        public DateTime DateEnd { get; set; }

        public Reservation(int id, User user, Product product, DateTime dateBegin, DateTime dateEnd, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            User = user;
            Product = product;
            DateBegin = dateBegin;
            DateEnd = dateEnd;
        }
    }
}
