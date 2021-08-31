using StarWarsDatabank.Framework.DomainFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharSpecies = StarWarsDatabank.Species.FFG.Domain.AggregatesModel;

namespace StarWarsDatabank.Character.FFG.Domain.AggregatesModel.Character
{
    public class Character : AggregateBase
    {
        public CharSpecies.Species CharacterSpecies { get; set; } = new CharSpecies.Species();
        public AbilityBlock Abilities { get; set; } = new AbilityBlock();

    }
}
