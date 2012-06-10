using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Model.Security
{
    public class Userprofile : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public static Userprofile Create()
        {
            return new Userprofile()
            {
                FirstName = string.Empty,
                LastName = string.Empty
            };
        }
    }
}
