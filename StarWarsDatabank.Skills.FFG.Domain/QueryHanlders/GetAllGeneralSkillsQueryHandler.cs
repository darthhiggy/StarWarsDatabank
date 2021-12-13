using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetAllGeneralSkillsQueryHandler : IRequestHandler<GetAllGeneralSkillsQuery, List<GeneralSkill>>
    {
        private readonly ISkillRepository _skillRepository;

        public GetAllGeneralSkillsQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public Task<List<GeneralSkill>> Handle(GetAllGeneralSkillsQuery request, CancellationToken cancellationToken) => 
            new Task<List<GeneralSkill>>(() =>
        {
            return _skillRepository.GetAllGenericSkills();
        });
    }
}
