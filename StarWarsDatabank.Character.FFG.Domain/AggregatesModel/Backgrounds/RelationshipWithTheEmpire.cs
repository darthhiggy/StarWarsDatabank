using StarWarsDatabank.Framework.DomainFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Character.FFG.Domain.AggregatesModel.Backgrounds
{
    public class RelationshipWithTheEmpire : EntityBase
    {
        public RelationshipWithTheEmpire()
        {
        }

        public RelationshipWithTheEmpire(int entityId) : base(entityId)
        {
        }
    }
}
