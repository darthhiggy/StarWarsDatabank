using StarWarsDatabank.Framework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Skills.FFG.Domain.SeedWork
{
    public interface ISkill
    {
        int AggregateId { get; }
        string Name { get; set; }
        string Description {  get; set; }   
        Ability Characteristic {  get; set; }
    }
}
