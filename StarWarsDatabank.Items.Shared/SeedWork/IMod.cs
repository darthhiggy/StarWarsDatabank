using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods;

namespace StarWarsDatabank.Items.FFG.Domain.SeedWork
{
    public interface IMod : IItemBase
    {
        string BaseModifier { get; set; }
        double Encumberance { get; set; }
        string FurtherMods { get; set; }
        int HardPoints { get; set; }
        bool IsRestricted { get; set; }
        int Price { get; set; }
        int Rarity { get; set; }
        ModType Type { get; set; }
    }
}