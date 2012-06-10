using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;
using RPA.Model.Security;

namespace RPA.Data.Security
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByName(string name);
    }
}
