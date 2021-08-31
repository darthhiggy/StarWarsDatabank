using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Talents.FFG.Domain.SeedWork;

namespace StarWarsDatabank.Talents.FFG.Domain.AggregatesModel
{
    public class Talent : AggregateBase, ITalent
    {
        public Talent(int aggregateId, TalentActivation activation) : base(aggregateId)
        {
            Activation = activation;
        }

        public TalentActivation Activation { get; private set; }
        public bool Ranked { get; set; }
        public int Rank { get; set; } = 0;
    }
}
