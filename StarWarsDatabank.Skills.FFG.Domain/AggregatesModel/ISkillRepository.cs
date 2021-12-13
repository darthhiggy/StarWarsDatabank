using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.CombatSkills;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.GeneralSkills;
using StarWarsDatabank.Skills.FFG.Domain.AggregatesModel.KnowledgeSkills;
using StarWarsDatabank.Skills.FFG.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.AggregatesModel
{
    public interface ISkillRepository
    {
        List<ISkill> GetAllSkills();
        List<CombatSkill> GetAllCombatSkills();
        List<GeneralSkill> GetAllGenericSkills();
        List<KnowledgeSkill> GetKnowledgeSkills();
        KnowledgeSkill GetKnowledgeSkillById(int id);
        CombatSkill GetCombatSkillById(int id);
        GeneralSkill GetGeneralSkillById(int id);
    }
}
