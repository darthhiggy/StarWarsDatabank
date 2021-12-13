using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetGeneralSkillByIdQuery : IRequest<GeneralSkill>
    {
        public int AggregateId { get; set; }
    }
}
