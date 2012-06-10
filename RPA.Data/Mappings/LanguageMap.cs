using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RPA.Model.Abilities;
using FluentNHibernate.MappingModel;

namespace RPA.Data.Mappings
{
    public class LanguageMap : ClassMap<Language>
    {
        public LanguageMap()
        {
            Table("Language");
            Id(x => x.Id)
                .GeneratedBy.Assigned();
            Map(x => x.Name)
                .Length(100);

        }

    }
}
