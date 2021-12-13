using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills;
using System.Collections.Generic;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetAllGeneralSkillsQuery : IRequest<List<GeneralSkill>>
    {

    }
}
