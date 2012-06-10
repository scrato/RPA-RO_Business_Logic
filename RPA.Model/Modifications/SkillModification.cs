using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model.Abilities;

namespace RPA.Model.Modifications
{
    public class SkillModification : Entity
    {
        public Skill Skill;
        public int Modification;
        public string Reason;
    }
}
