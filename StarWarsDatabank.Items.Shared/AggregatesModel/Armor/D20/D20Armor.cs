using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.Armor.D20
{
    public class D20Armor
    {
        public int D20ArmorId { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public int DamageReduction { get; set; }

        public int MaximumDexBonus { get; set; }

        public int ArmorCheckPenalty { get; set; }

        public int SpeedAt10m { get; set; }

        public int SpeedAt6m { get; set; }

        public int Weight { get; set; }


    }
}
