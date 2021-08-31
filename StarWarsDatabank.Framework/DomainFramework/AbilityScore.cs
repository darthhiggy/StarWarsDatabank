
using StarWarsDatabank.Framework.Enums;

namespace StarWarsDatabank.Framework.DomainFramework
{
    public class AbilityScore
    {
        public Ability Type { get; set; }
        public int Score { get; set; } = 0;
    }
}