using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetCombatSkillByIdQueryHandler : IRequestHandler<GetCombatSkillByIdQuery, CombatSkill>
    {
        private readonly ISkillRepository _skillRepository;

        public GetCombatSkillByIdQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public CombatSkill Handle(GetCombatSkillByIdQuery query) => _skillRepository.GetCombatSkillById(query.AggregateId);

        public Task<CombatSkill> Handle(GetCombatSkillByIdQuery request, CancellationToken cancellationToken) =>
            new Task<CombatSkill>(() =>
            {
                return _skillRepository.GetCombatSkillById(request.AggregateId);
            });
    }
}
