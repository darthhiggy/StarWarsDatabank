using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Framework.DomainFramework
{
    public class EntityBase
    {
        public EntityBase()
        {
            EntityId = 0;
        }

        public EntityBase(int entityId)
        {
            EntityId = entityId;
        }

        public int EntityId { get; private set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<BookReference> Books { get; set; } = new List<BookReference>();

    }
}
