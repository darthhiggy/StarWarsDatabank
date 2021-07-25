using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.Domain.SeedWork
{
    public interface IItemBase
    {
        int AggregateId { get; set; }

        string Description{ get; set; }
    }
}
