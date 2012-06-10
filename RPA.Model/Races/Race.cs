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
        public virtual string Name;
        public virtual List<AttributeModification> AttributeMods;
        public virtual List<SkillModification> SkillMods;
        public virtual List<Feat> Feats;
        public virtual List<SpecialAbility> Abilities;

    }

}
