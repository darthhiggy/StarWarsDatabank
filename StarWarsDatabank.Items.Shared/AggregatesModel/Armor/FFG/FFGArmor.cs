using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.Armor.FFG
{
    public class FFGArmor
    {
        public int FFGArmorId { get; set; }

        public int Soak { get; set; }

        public int Defense { get; set; }

        public int Encumberance { get; set; }

        public int HardPoints { get; set; }

        public int Price { get; set; }

        public int Rarity { get; set; }

        public string Speical { get; set; }

        public string Description { get; set; }

        public List<Quality> Qualities { get; set; }
    }
}
