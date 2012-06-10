using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model.Security;
using FluentNHibernate.Mapping;

namespace RPA.Data.Mappings
{
    public class ProfileMap : ClassMap<Userprofile>
    {
        public ProfileMap()
        {
            Table("Profiles");
            Id(x => x.Id)
                .GeneratedBy.Assigned();
            Map(x => x.FirstName)
                .Length(100);
            Map(x => x.LastName)
                .Length(100);
        }
    }
}
