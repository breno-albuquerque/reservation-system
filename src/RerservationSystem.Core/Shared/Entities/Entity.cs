namespace RerservationSystem.Core.Shared.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime DateInsertion { get; set; }

        public DateTime DateAlteration { get; set; }

        public Entity(int id, DateTime dateInsertion, DateTime dateAlteration)
        {
            Id = id;
            DateInsertion = dateInsertion;
            DateAlteration = dateAlteration;
        }

        public Entity(DateTime dateInsersion, DateTime dateAlteration)
        {
            DateInsertion = dateInsersion;
            DateAlteration = dateAlteration;
        }
    }
}
