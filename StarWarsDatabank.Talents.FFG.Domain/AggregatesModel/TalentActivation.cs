using StarWarsDatabank.Framework.DomainFramework;

namespace StarWarsDatabank.Talents.FFG.Domain.AggregatesModel
{
    public class TalentActivation : EntityBase
    {
        public TalentActivation()
        {

        }

        public TalentActivation(int entityId) : base(entityId)
        {
        }
    }
}
