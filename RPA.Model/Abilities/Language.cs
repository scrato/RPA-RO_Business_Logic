using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model.Races;

namespace RPA.Model.Abilities
{
    public class Language : Entity
    {
        public  string Name;

        public static Language Create()
        {
            return new Language()
            {
                Name = string.Empty
            };
        }
    }
}
