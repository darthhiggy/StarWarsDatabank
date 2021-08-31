namespace StarWarsDatabank.Framework
{
    public class GameVersion
    {
        public int GameVersionId { get; set; }

        public int Name { get; set; }

        public string Abbreviation { get; set; }

        public override string ToString() => Abbreviation;
    }
}
