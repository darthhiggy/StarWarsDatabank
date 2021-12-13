using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;
using System.Collections.Generic;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetAllKnowledgeSkillsQuery : IRequest<List<KnowledgeSkill>>
    {
    }
}
