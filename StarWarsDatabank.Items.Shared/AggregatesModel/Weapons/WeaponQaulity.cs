using StarWarsDatabank.Framework.DomainFramework;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons
{
    public class WeaponQaulity : EntityBase
    {
        public WeaponQaulity()
        {
        }

        public WeaponQaulity(int entityId) : base(entityId)
        {
        }

        public string Rule { get; set; }
    }
}
