using StarWarsDatabank.Framework.DomainFramework;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons
{
    public class WeaponQuality : EntityBase
    {
        public WeaponQuality()
        {
        }

        public WeaponQuality(int entityId) : base(entityId)
        {
        }

        public string Rule { get; set; }
        public List<Weapon> Weapons { get; set; }
    }
}
