using StarWarsDatabank.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.WEG
{
    public class WEGGear
    {
        public int WEGGearId { get; set; }

        public string Description { get; set; }

        public Book RPGBook { get; set; }
    }
}
