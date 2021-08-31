using StarWarsDatabank.Framework.DomainFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.SeedWork
{
    public class ItemBase : AggregateBase, IItemBase
    {
        public ItemBase() : base()  
        {

        }

        public ItemBase(int aggregateId) : base(aggregateId)
        {

        }
    }
}
