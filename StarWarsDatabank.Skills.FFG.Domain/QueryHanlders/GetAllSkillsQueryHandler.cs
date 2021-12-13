using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetAllSkillsQueryHandler : IRequestHandler<GetAllSkillsQuery, List<ISkill>>
    {
        private readonly ISkillRepository _skillRepository;
        public GetAllSkillsQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        public List<ISkill> Handle(GetAllSkillsQuery query) => _skillRepository.GetAllSkills();

        public Task<List<ISkill>> Handle(GetAllSkillsQuery request, CancellationToken cancellationToken) =>
            new Task<List<ISkill>>(() =>
            {
                return _skillRepository.GetAllSkills();
            });
    }
}
