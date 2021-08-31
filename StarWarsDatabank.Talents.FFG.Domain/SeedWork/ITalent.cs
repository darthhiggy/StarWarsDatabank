using StarWarsDatabank.Talents.FFG.Domain.AggregatesModel;

namespace StarWarsDatabank.Talents.FFG.Domain.SeedWork
{
    public interface ITalent 
    {
       int AggregateId { get; }

       string Name { get; set; }

       string Description { get; set; }

       TalentActivation Activation { get;}

       bool Ranked { get; set; }
    }
}
