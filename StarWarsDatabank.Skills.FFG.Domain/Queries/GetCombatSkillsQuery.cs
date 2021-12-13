using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;
using System.Collections.Generic;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetCombatSkillsQuery : IRequest<List<CombatSkill>>
    {

    }
}
