using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetAllKnowledgeSkillsQueryHandler : IRequestHandler<GetAllKnowledgeSkillsQuery, List<KnowledgeSkill>>
    {
        private readonly ISkillRepository _skillRepository;

        public GetAllKnowledgeSkillsQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public Task<List<KnowledgeSkill>> Handle(GetAllKnowledgeSkillsQuery request, CancellationToken cancellationToken) =>
            new Task<List<KnowledgeSkill>>(() =>
            {
                return _skillRepository.GetKnowledgeSkills();
            });
    }
}
