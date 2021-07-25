using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Items.Domain.AggregatesModel.Armor.FFG;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.Armor
{
    public class Armor : AggregateBase
    {
        public ArmorCategory Category { get; set; }

        // FFG
        public FFGArmor FFGArmor { get; set; }

        // D20


        // Saga

        // WEG
    }
}
