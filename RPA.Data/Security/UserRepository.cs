using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using RPA.Core;
using RPA.Model.Security;

namespace RPA.Data.Security
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(IDataContext dataContext)
            : base(dataContext)
        {

        }

        public User GetByName(string name)
        {
            var query = from u in Session.Query<User>()
                        where u.Name == name
                        select u;
            return query.FirstOrDefault();
        }

    }
}
