using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Careers.FFG.Domain.AggregateModel.Careers
{
    public class Career : AggregateBase
    {
        public Career()
        {
        }

        public Career(int aggregateId) : base(aggregateId)
        {
        }

        public string Role { get; set; } = "";

        public string Specializations { get; set; } = "";

        public List<string> Stories { get; set; } = new List<string>(); 

        public List<ISkill> Skills { get; set; } = new List<ISkill>();


    }
}
