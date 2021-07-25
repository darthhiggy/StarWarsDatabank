using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Framework.DomainFramework
{
    public class AggregateBase
    {
        public int AggregateId { get; set; }

        public List<Book> Books { get; set; }
    }
}
