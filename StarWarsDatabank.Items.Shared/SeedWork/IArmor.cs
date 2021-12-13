using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor;
using System.Collections.Generic;

namespace StarWarsDatabank.Items.FFG.Domain.SeedWork
{
    public interface IArmor : IItemBase
    {
        ArmorCategory Category { get; set; }
        int Defense { get; set; }
        int Encumberance { get; set; }
        int HardPoints { get; set; }
        int Price { get; set; }
        List<ArmorQuality> Qualities { get; set; }
        int Rarity { get; set; }
        int Soak { get; set; }
        string Speical { get; set; }
    }
}