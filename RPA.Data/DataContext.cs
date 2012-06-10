using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using RPA.Core;

namespace RPA.Data
{
    public class DataContext : ServiceBase, IDataContext
    {
        public DataContext(IAppContext appContext)
            : base(appContext)
        {
            Session = SessionHelper.OpenSession();
            AppContext.AddObject<ISession>(Session);
        }

        public ISession Session { get; private set; }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
                Session.Dispose();
            base.Dispose(isDisposing);
        }

        public bool IsDirty
        {
            get { return Session.IsDirty(); }
        }

        public void SaveChanges()
        {
            Session.Flush();
        }
    }
}
