using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetCombatSkillsQueryHandler : IRequestHandler<GetCombatSkillsQuery, List<CombatSkill>>
    {
        private readonly ISkillRepository _skillRepository;

        public GetCombatSkillsQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public Task<List<CombatSkill>> Handle(GetCombatSkillsQuery request, CancellationToken cancellationToken) =>
            new Task<List<CombatSkill>>(() =>
            {
                return _skillRepository.GetAllCombatSkills();
            });
    }
}
