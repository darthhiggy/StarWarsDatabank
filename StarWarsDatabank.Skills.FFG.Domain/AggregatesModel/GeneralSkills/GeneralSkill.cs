using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills
{
    public class GeneralSkill : SkillBase
    {
        public GeneralSkill()
        {
        }

        public GeneralSkill(int aggregateId) : base(aggregateId)
        {
        }
    }
}
