using RerservationSystem.Core.Shared.Entities;

namespace RerservationSystem.Core.Shared.Services.Entities
{
    public class Service : Entity
    {
        public ServiceType ServiceType { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public Service(int id, ServiceType serviceType, string name, int capacity, DateTime dateInsertion, DateTime dateAlteration)
            : base(id, dateInsertion, dateAlteration)
        {
            ServiceType = serviceType;
            Name = name;
            Capacity = capacity;
        }
    }
}
