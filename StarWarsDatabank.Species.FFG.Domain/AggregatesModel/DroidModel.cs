using StarWarsDatabank.Framework.DomainFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Species.FFG.Domain.AggregatesModel
{
    public class DroidModel : EntityBase
    {
        public DroidModel()
        {
        }

        public DroidModel(int entityId) : base(entityId)
        {
        }
    }
}
