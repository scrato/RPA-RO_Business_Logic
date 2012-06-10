using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace RPA.Data
{
    public static class SessionHelper
    {
        private const string FileName = "data.db";
        public static bool flushSchema;
        private static ISessionFactory _factory;

        static SessionHelper()
        {
            _factory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(FileName).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DataContext>())
                .ExposeConfiguration(ExportSchema)
                .BuildSessionFactory();
        }

        private static void ExportSchema(Configuration config)
        {
            var schema = new SchemaExport(config);
            // Auf false setzen, wenn kein neuer Account
            flushSchema = true;
            schema.Create(true, true);
            
        }

        public static ISession OpenSession()
        {
            var session = _factory.OpenSession();
            session.FlushMode = FlushMode.Never;
            return session;
        }
    }
}
