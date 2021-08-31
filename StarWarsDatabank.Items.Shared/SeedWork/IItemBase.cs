namespace StarWarsDatabank.Items.FFG.Domain.SeedWork
{
    public interface IItemBase
    {
        int AggregateId { get; }

        string Description{ get; set; }
    }
}
