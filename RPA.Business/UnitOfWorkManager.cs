using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;

namespace RPA.Business
{
    public class UnitOfWorkManager : ServiceBase, IUnitOfWorkManager
    {
        public UnitOfWorkManager(IAppContext appContext)
            : base(appContext)
        {
            Items = new List<IUnitOfWork>();
        }

        public List<IUnitOfWork> Items { get; private set; }

        public bool IsRoot(IUnitOfWork uow)
        {
            return Items.IndexOf(uow) == 0;
        }

        public bool CanComplete(IUnitOfWork uow)
        {
            var index = Items.IndexOf(uow);
            if (index < 0)
                return false;
            index++;
            for (var i = index; i < Items.Count; i++)
            {
                if (Items[i].State != UnitOfWorkState.Completed)
                    return false;
            }
            return true;
        }

        public void Add(IUnitOfWork uow)
        {
            Items.Add(uow);
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}
