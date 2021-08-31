using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills
{
    public class KnowledgeSkill : SkillBase
    {
        public KnowledgeSkill()
        {
        }

        public KnowledgeSkill(int aggregateId) : base(aggregateId)
        {
        }
    }
}
