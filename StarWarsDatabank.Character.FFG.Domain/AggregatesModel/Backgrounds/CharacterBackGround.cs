using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Character.FFG.Domain.AggregatesModel.Backgrounds
{
    public class CharacterBackGround
    {
        public CulturalBackground CulturalBackground { get; set; } = new CulturalBackground();
        public EnteringLifeAsAMiscreant EnteringLifeAsAMiscreant { get; set; } = new EnteringLifeAsAMiscreant();
        public RelationshipWithTheEmpire RelationshiptWithTheEmpire { get; set; } = new RelationshipWithTheEmpire();
        public JoiningTheRebellion JoiningTheRebellion { get; set; } = new JoiningTheRebellion();
        public ExperiencingTheForce ExperiencingTheForce { get; set; } = new ExperiencingTheForce();
        public HeadingTheCall HeadingTheCall { get; set; } = new HeadingTheCall();
    }
}
