using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Enums;

namespace RerservationSystem.Core.Shared.Services.Entities
{
    public class ServiceType : Entity
    {
        public ETypeName TypeName { get; set; }

        public ServiceType(int id, ETypeName typeName, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            TypeName = typeName;
        }
    }
}
