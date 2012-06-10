using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Model.Security
{
    public class User : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
        public virtual Userprofile Profile { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static User Create(string name, string password)
        {
            return new User()
            {
                Name = name,
                Password = password,
                Profile = Userprofile.Create()
            };
        }
    }
}
