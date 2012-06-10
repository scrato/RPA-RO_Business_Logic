using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Data;

namespace RPA.Business
{
    public enum UnitOfWorkState
    {
        Active,
        Completed,
        Canceled
    }

    public interface IUnitOfWork : IDisposable
    {
        UnitOfWorkState State { get; }
        void Complete();
    }
}
