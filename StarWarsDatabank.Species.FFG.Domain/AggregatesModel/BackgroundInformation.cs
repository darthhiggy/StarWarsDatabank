using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Species.FFG.Domain.AggregatesModel
{
    public class BackgroundInformation
    {
        public BackgroundInformation()
        {
            Physiology = "";
            Society = "";
            Homeworld = "";
            Language = "";
            LifeOnTheFringe = "";
        }
        public string Physiology { get; set; }
        public string Society { get; set; }
        public string Homeworld { get; set; }
        public string Language { get; set; }
        public string LifeOnTheFringe { get; set; }
    }
}
