using StarWarsDatabank.Framework.DomainFramework;

using System;

namespace StarWarsDatabank.Framework
{
    public class Book : Value<Book>
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public int GameVersionId { get; set; }
        public GameVersion RPG { get; set; }

        public string Abbreviation { get; set; }

        public override string ToString() => $"{Abbreviation}-{RPG}";
    }
}
