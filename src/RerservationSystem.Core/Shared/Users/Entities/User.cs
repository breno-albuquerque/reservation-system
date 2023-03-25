using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Roles.Entities;
using RerservationSystem.Core.Shared.ValueObjects;

namespace RerservationSystem.Core.Shared.Users.Entities
{
    public class User : Entity
    {
        public Role UserRole { get; set; }

        public Document Document { get; set; }

        public Email Email { get; set; }

        public string Password { get; set; }

        public User(int id, Role userRole, Document document, Email email, string password, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            UserRole = userRole;
            Document = document;
            Email = email;
            Password = password;
        }
    }
}
