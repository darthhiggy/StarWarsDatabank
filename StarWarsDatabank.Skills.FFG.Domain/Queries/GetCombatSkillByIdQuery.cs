using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetCombatSkillByIdQuery : IRequest<CombatSkill>
    {
        public int AggregateId { get; set; }
    }
}
