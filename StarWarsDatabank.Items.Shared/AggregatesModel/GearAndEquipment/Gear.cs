using StarWarsDatabank.Items.FFG.Domain.SeedWork;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.GearAndEquipment
{
    public class Gear : ItemBase
    {
        public Gear()
        {
        }

        public Gear(int aggregateId) : base(aggregateId)
        {
        }

        public GearCategory Category { get; set; }

        public int Encumberance { get; set; }

        public int Price { get; set; }

        public int Rarity { get; set; }

        public string Special { get; set; }
    }
}
