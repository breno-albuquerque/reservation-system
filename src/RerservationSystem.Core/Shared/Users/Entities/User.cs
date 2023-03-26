using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Roles.Enums;

namespace RerservationSystem.Core.Shared.Users.Entities
{
    public class User : Entity
    {
        public string Document { get; set; }

        public string Email { get; set; }

        public ERole UserRole { get; set; }

        public string Password { get; set; }

        public User(int id, DateTime dateInsertion, DateTime dateAlteration, string document, string email, ERole role, string password)
            : base(id, dateInsertion, dateAlteration)
        {
            Document = document;
            Email = email;
            UserRole = role;
            Password = password;
        }

        public User(DateTime dateInsertion, DateTime dateAlteration, string document, string email, ERole role, string password)
            : base(dateInsertion, dateAlteration)
        {
            Document = document;
            Email = email;
            UserRole = role;
            Password = password;
        }
    }
}
