using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetKnowledgeSkillByIdQuery : IRequest<KnowledgeSkill>
    {
        public int AggregateId { get; set; }
    }
}
