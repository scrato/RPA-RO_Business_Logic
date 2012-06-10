using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;

namespace RPA.Data
{
    public interface IDataContext : IServiceBase
    {
        bool IsDirty { get; }
        void SaveChanges();
    }
}
