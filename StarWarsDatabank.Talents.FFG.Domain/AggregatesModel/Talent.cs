using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Talents.FFG.Domain.SeedWork;

namespace StarWarsDatabank.Talents.FFG.Domain.AggregatesModel
{
    public class Talent : AggregateBase, ITalent
    {
        public Talent(int aggregateId) : base(aggregateId)
        {
        }

        public TalentActivation Activation { get; set; } = new TalentActivation();
        public bool Ranked { get; set; }
        public int Rank { get; set; } = 0;
    }
}
