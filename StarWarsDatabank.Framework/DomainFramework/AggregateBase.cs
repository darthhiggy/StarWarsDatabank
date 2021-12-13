namespace StarWarsDatabank.Framework.DomainFramework
{
    public class AggregateBase : IAggregateBase
    {
        public int AggregateId { get; private set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<BookReference> Books { get; set; } = new List<BookReference>();

        public AggregateBase()
        {
            AggregateId = 0;
        }

        public AggregateBase(int aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
