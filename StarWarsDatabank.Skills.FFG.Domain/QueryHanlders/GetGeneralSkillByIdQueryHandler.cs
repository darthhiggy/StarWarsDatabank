using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills;
using StarWarsDatabank.Skills.FFG.Domain.Queries;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.QueryHanlders
{
    public class GetGeneralSkillByIdQueryHandler : IRequestHandler<GetGeneralSkillByIdQuery, GeneralSkill>
    {
        private readonly ISkillRepository _skillRepository;

        public GetGeneralSkillByIdQueryHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public Task<GeneralSkill> Handle(GetGeneralSkillByIdQuery request, CancellationToken cancellationToken) =>
            new Task<GeneralSkill>(() =>
            {
                return _skillRepository.GetGeneralSkillById(request.AggregateId); ;
            });
    }
}
