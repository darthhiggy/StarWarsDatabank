using StarWarsDatabank.Framework.DomainFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Armor
{
    public class ArmorCategory : EntityBase
    {
        public ArmorCategory()
        {
        }

        public ArmorCategory(int entityId) : base(entityId)
        {
        }
    }
}
