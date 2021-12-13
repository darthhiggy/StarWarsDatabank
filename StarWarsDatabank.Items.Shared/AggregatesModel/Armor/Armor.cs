using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Items.FFG.Domain.SeedWork;
using System.Collections.Generic;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor
{
    public class Armor : ItemBase, IArmor
    {

        public Armor() : base()
        {

        }

        public Armor(int aggregateId) : base(aggregateId)
        {

        }

        public ArmorCategory Category { get; set; }

        // FFG
        public int Soak { get; set; }

        public int Defense { get; set; }

        public int Encumberance { get; set; }

        public int HardPoints { get; set; }

        public int Price { get; set; }

        public int Rarity { get; set; }

        public string Speical { get; set; }

        public List<ArmorQuality> Qualities { get; set; }
       
    }
}
