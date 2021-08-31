using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills
{
    public class CombatSkill : SkillBase
    {
        public CombatSkill()
        {
        }

        public CombatSkill(int aggregateId) : base(aggregateId)
        {
        }
    }
}
