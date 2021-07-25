using StarWarsDatabank.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.AggregatesModel.GearAndEquipment.Saga
{
    public class SagaGear
    {
        public int SagaGearId { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public double Weight { get; set; }

        public Book RPGBook { get; set; }
    }
}
