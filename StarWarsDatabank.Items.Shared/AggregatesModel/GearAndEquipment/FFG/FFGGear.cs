using StarWarsDatabank.Framework;
using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Items.Domain.SeedWork;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.FFG
{
    public class FFGGear
    {
        public int FFGearId { get; set; }

        public int Encumberance { get; set; }

        public int Price { get; set; }

        public int Rarity { get; set; }

        public string Description { get; set; }

        public string Special { get; set; }

        public Book RPGBook { get; set; }

    }
}
