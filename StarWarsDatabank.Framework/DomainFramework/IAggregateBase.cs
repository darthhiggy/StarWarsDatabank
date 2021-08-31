namespace StarWarsDatabank.Framework.DomainFramework
{
    public interface IAggregateBase
    {
        int AggregateId { get; }
        List<BookReference> Books { get; set; }
        string Description { get; set; }
        string Name { get; set; }
    }
}