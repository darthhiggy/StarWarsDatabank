using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Framework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.SeedWork
{
    public class SkillBase : AggregateBase, ISkill
    {
        public SkillBase()
        {
        }

        public SkillBase(int aggregateId) : base(aggregateId)
        {
        }

        public Ability Characteristic { get; set; }
    }
}
