using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment;

namespace StarWarsDatabank.Items.FFG.Domain.SeedWork
{
    public interface IGear : IItemBase
    {
        GearCategory Category { get; set; }
        int Encumberance { get; set; }
        int Price { get; set; }
        int Rarity { get; set; }
        string Special { get; set; }
    }
}