using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;

namespace RPA.Business
{
    public interface IUnitOfWorkManager : IServiceBase
    {
        bool IsRoot(IUnitOfWork uow);
        bool CanComplete(IUnitOfWork uow);
        void Add(IUnitOfWork uow);
        void Clear();
    }
}
