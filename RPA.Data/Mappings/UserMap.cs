using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RPA.Model.Security;
using FluentNHibernate.MappingModel;

namespace RPA.Data.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.Id)
                .GeneratedBy.Assigned();
            Map(x => x.Name)
                .Length(50);
            Map(x => x.Password)
                .Length(50);
            References(x => x.Profile)
                .Cascade.All();
        }
    }
}
