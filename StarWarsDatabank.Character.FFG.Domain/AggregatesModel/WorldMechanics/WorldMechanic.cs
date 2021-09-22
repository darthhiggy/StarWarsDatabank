using StarWarsDatabank.Framework.DomainFramework;

namespace StarWarsDatabank.Character.FFG.Domain.AggregatesModel.WorldMechanics
{
    public class WorldMechanic : EntityBase
    {
        public WorldMechanic()
        {
        }

        public WorldMechanic(int entityId) : base(entityId)
        {
        }

        public int DiceRollMin { get; set; }

        public int DiceRollMax { get; set; }

        public WorldMechanicType Type { get; set; }

    }
}
