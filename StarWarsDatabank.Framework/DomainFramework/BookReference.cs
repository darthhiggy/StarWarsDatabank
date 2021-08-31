using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Framework.DomainFramework
{
    public class BookReference
    { 
        public int BookId { get; set; }
        public string Section { get; set; }
        public int PageNumber { get; set; }
    }
}
