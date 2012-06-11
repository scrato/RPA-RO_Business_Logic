using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model.Modifications;
using RPA.Model.Abilities;

namespace RPA.Model.Races
{
    public class Race : Entity
    {
        public  string Name;
        public  List<AttributeModification> AttributeMods;
        public  List<SkillModification> SkillMods;
        public  List<Feat> Feats;
        public  List<SpecialAbility> Abilities;

    }

}
