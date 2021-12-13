using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetKnowledgeSkillByIdQueryHandler : IRequestHandler<GetKnowledgeSkillByIdQuery, KnowledgeSkill>
    {
        private readonly ISkillRepository _skillRepository;

        public GetKnowledgeSkillByIdQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public KnowledgeSkill Handle(GetKnowledgeSkillByIdQuery query) => _skillRepository.GetKnowledgeSkillById(query.AggregateId);

        public Task<KnowledgeSkill> Handle(GetKnowledgeSkillByIdQuery request, CancellationToken cancellationToken) =>
            new Task<KnowledgeSkill>(() =>
            {
                return _skillRepository.GetKnowledgeSkillById(request.AggregateId);
            });
    }
}
