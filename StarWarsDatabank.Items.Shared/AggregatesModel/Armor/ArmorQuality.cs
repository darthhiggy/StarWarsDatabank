using StarWarsDatabank.Framework.DomainFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor
{
    public class ArmorQuality : EntityBase
    {
        public ArmorQuality()
        {
        }

        public ArmorQuality(int entityId) : base(entityId)
        {
        }

        public List<Armor> Armors { get; set; }

    }
}
