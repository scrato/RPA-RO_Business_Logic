using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model.Races;

namespace RPA.Model.Charsheet
{
    public class CharacterProfile : Entity
    {
                public virtual string FirstName;
                public virtual string LastName;
                public virtual int Age;
                public virtual Race Race;
                public virtual String Description;

                
    }
}
