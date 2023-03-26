using RerservationSystem.Core.Shared.Entities;
using RerservationSystem.Core.Shared.Enums;

namespace RerservationSystem.Core.Shared.Products.Entities
{
    public class ProductType : Entity
    {
        public ETypeName TypeName { get; set; }

        public ProductType(int id, ETypeName typeName, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            TypeName = typeName;
        }
    }
}
