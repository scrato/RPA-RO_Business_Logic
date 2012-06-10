using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;
using RPA.Data;

namespace RPA.Business
{
    public class UnitOfWork : DisposableObject, IUnitOfWork
    {
        public UnitOfWork(IDataContext dataContext, IUnitOfWorkManager manager)
        {
            State = UnitOfWorkState.Active;
            DataContext = dataContext;
            Manager = manager;
            Manager.Add(this);
        }

        public UnitOfWorkState State { get; private set; }
        public IDataContext DataContext { get; private set; }
        public IUnitOfWorkManager Manager { get; private set; }

        public void Complete()
        {
            if (!Manager.CanComplete(this))
                throw new UnitOfWorkWasNotCompletedException();
            if (Manager.IsRoot(this) && DataContext.IsDirty)
            {
                try
                {
                    DataContext.SaveChanges();
                }
                catch (UserException ex)
                {
                    throw new UnitOfWorkWasNotCompletedException(ex.Message, ex);
                }
            }
            State = UnitOfWorkState.Completed;
        }

        protected override void Dispose(bool isDisposing)
        {
            if (State == UnitOfWorkState.Active)
                State = UnitOfWorkState.Canceled;
            if (Manager.IsRoot(this))
                Manager.Clear();
            base.Dispose(isDisposing);
        }
    }
}
