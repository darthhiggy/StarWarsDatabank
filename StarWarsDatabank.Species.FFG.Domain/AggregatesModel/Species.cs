using StarWarsDatabank.Framework.DomainFramework;
using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using StarWarsDatabank.Species.FFG.Domain.SeedWork;
using StarWarsDatabank.Talents.FFG.Domain.AggregatesModel;

namespace StarWarsDatabank.Species.FFG.Domain.AggregatesModel
{
    public class Species : AggregateBase, ISpecies
    {
        public Species()
        {
        }

        public Species(int aggregateId, BackgroundInformation background, AbilityBlock abilities, int woundThresholdBase, int strainThresholdBase, Dictionary<ISkill, int> startingSkillRanks, List<Talent> startingTalents) : base(aggregateId)
        {
            Background = background;
            Abilities = abilities;
            WoundThresholdBase = woundThresholdBase;
            StrainThresholdBase = strainThresholdBase;
            StartingSkillRanks = startingSkillRanks;
            StartingTalents = startingTalents;
        }

        public BackgroundInformation Background { get; set; } = new BackgroundInformation();
        public AbilityBlock Abilities { get; set; } = new AbilityBlock();
        public int WoundThresholdBase { get; set; } = 10;
        public int WoundThreshold { get => WoundThresholdBase + Abilities.Brawn.Score; }
        public int StrainThresholdBase { get; set; } = 10;
        public int StrainThreshold { get => StrainThresholdBase + Abilities.Willpower.Score; }
        public int StartingXP { get; set; }
        public Dictionary<ISkill, int> StartingSkillRanks { get; set; } = new Dictionary<ISkill, int>();
        public List<Talent> StartingTalents { get; set; } = new List<Talent>();
        public SpeciesLife Life { get; set; } = new SpeciesLife();
    }
}
