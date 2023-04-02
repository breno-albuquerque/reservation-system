using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Roles.Enums;

namespace RerservationSystem.Core.Shared.Users.Entities
{
    public class User : Entity
    {
        public string Document { get; }

        public string Email { get; }

        public ERole UserRole { get; }

        public string PasswordHash { get; private set; }

        public User(string email, string document, ERole userRole, string? passwordHash, DateTime dateInsertion, DateTime dateAlteration)
            : base(dateInsertion, dateAlteration)
        {
            Document = document;
            Email = email;
            UserRole = userRole;
            PasswordHash = passwordHash ?? string.Empty;
        }

        public User(int id, string email, string document, ERole userRole, string? passwordHash, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            Document = document;
            Email = email;
            UserRole = userRole;
            PasswordHash = passwordHash ?? string.Empty;
        }

        public void SetPasswordHash(string passwordHash)
        {
            PasswordHash = passwordHash;
        }

        public static User Empty() => new(string.Empty, string.Empty, default, string.Empty, default, default);
    }
}
