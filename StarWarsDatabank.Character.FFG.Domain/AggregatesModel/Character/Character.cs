using StarWarsDatabank.Character.FFG.Domain.AggregatesModel.Backgrounds;
using StarWarsDatabank.Character.FFG.Domain.AggregatesModel.WorldMechanics;
using StarWarsDatabank.Framework.DomainFramework;
using CharSpecies = StarWarsDatabank.Species.FFG.Domain.AggregatesModel;

namespace StarWarsDatabank.Character.FFG.Domain.AggregatesModel.Character
{
    public class Character : AggregateBase
    {
        public CharSpecies.Species CharacterSpecies { get; set; } = new CharSpecies.Species();
        public AbilityBlock Abilities { get; set; } = new AbilityBlock();
        public CharacterBackGround BackGround { get; set; } = new CharacterBackGround();
        public List<WorldMechanic> Mechanic { get; set; } = new List<WorldMechanic>();
    }
}
