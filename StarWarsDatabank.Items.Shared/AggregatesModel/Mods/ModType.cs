using StarWarsDatabank.Framework.DomainFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods
{
    public class ModType : EntityBase
    {
        public ModType()
        {
        }

        public ModType(int entityId) : base(entityId)
        {
        }
    }
}
