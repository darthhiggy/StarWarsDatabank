using StarWarsDatabank.Framework.Enums;
using StarWarsDatabank.Items.FFG.Domain.SeedWork;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Weapons
{
    public class Weapon : ItemBase
    {
        public Weapon()
        {
        }

        public Weapon(int aggregateId) : base(aggregateId)
        {
        }

        public int CombatSkillId { get; set; }

        public CombatSkill Skill { get; set; }

        public int Damage { get; set; }

        public bool AddAbilityScoreToDamage { get; set; }

        public int Critical { get; set; }

        public RangeBands Range { get; set; }

        public double Encumberance { get; set; }

        public int HardPoints { get; set; }

        public int Price { get; set; }

        public bool Restricted { get; set; }

        public int Rarity { get; set; }

        public List<WeaponQuality> Qualities { get; set; }

    }
}
