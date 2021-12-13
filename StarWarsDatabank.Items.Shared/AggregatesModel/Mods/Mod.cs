using StarWarsDatabank.Items.FFG.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods
{
    public class Mod : ItemBase, IMod
    {
        public ModType Type { get; set; }

        public int HardPoints { get; set; }

        public double Encumberance { get; set; }

        public int Price { get; set; }

        public bool IsRestricted { get; set; }

        public int Rarity { get; set; }

        public string BaseModifier { get; set; }

        public string FurtherMods { get; set; }
    }
}
