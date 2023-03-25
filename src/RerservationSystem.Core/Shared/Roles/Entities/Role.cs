using RerservationSystem.Core.Shared.Entities;

namespace RerservationSystem.Core.Shared.Roles.Entities
{
    public class Role : Entity
    {
        public string RoleName { get; set; }

        public Role(int id, string roleName, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            RoleName = roleName;
        }
    }
}
