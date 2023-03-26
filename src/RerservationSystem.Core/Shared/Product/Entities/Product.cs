using RerservationSystem.Core.Shared.Entities;

namespace RerservationSystem.Core.Shared.Product.Entities
{
    public class Product : Entity
    {
        public ProductType ServiceType { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public Product(int id, ProductType serviceType, string name, int capacity, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            ServiceType = serviceType;
            Name = name;
            Capacity = capacity;
        }
    }
}
