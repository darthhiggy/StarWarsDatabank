using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using StarWarsDatabank.Species.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Talents.FFG.Domain.AggregatesModel;

namespace StarWarsDatabank.Species.FFG.Domain.SeedWork
{
    public interface ISpecies : IAggregateBase
    {
        AbilityBlock Abilities { get; set; }
        BackgroundInformation Background { get; set; }
        SpeciesLife Life { get; set; }
        Dictionary<ISkill, int> StartingSkillRanks { get; set; }
        List<Talent> StartingTalents { get; set; }
        int StartingXP { get; set; }
        int StrainThreshold { get; }
        int StrainThresholdBase { get; set; }
        int WoundThreshold { get; }
        int WoundThresholdBase { get; set; }
    }
}