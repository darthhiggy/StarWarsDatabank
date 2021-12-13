using MediatR;
using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System.Collections.Generic;

namespace StarWarsDatabank.Skills.FFG.Domain.Queries
{
    public class GetAllSkillsQuery : IRequest<List<ISkill>>
    {

    }
}
