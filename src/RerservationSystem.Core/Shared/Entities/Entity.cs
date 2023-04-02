namespace RerservationSystem.Core.Shared.Entities
{
    public abstract class Entity
    {
        public int Id { get; }

        public DateTime DateInsertion { get; }

        public DateTime DateAlteration { get; }

        public Entity(DateTime dateInsertion, DateTime dateAlteration)
        {
            DateInsertion = dateInsertion;
            DateAlteration = dateAlteration;
        }

        public Entity(int id, DateTime dateInsertion, DateTime dateAlteration)
            : this(dateInsertion, dateAlteration)
        {
            Id = id;
        }
    }
}
