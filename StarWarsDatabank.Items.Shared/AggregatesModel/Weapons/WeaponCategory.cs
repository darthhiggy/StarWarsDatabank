using StarWarsDatabank.Framework.DomainFramework;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons
{
    public class WeaponCategory : EntityBase
    {
        public WeaponCategory()
        {
        }

        public WeaponCategory(int entityId) : base(entityId)
        {
        }
    }
}
