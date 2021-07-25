using StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.D20;
using StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.FFG;
using StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.Saga;
using StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.WEG;
using StarWarsDatabank.Items.Domain.SeedWork;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment
{
    public class Gear : ItemBase
    {
        public GearCategory Category { get; set; }

        // FFG
        public FFGGear FFGGear { get; set; }

        // D20
        public D20Gear D20Gear { get; set; }

        // Saga
        public SagaGear SagaGear{ get; set; }

        // WEG
        public WEGGear WEGGear { get; set; }
    }
}
