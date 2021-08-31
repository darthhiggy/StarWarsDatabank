namespace StarWarsDatabank.Framework.DomainFramework
{
    public class AbilityBlock
    {
        public AbilityScore Brawn { get; set; } = new AbilityScore();
        public AbilityScore Agility { get; set; } = new AbilityScore();
        public AbilityScore Intellect { get; set; } = new AbilityScore();
        public AbilityScore Cunning { get; set; } = new AbilityScore();
        public AbilityScore Willpower { get; set; } = new AbilityScore();
        public AbilityScore Presence { get; set; } = new AbilityScore();
    }
}
