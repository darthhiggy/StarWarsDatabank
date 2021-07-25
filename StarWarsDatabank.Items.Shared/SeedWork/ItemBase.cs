using StarWarsDatabank.Framework.DomainFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.SeedWork
{
    public class ItemBase : AggregateBase, IItemBase
    {
        public string Description { get; set; }
    }
}
