using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Core
{
    public interface IServiceBase
    {
        IAppContext AppContext { get; }
    }
}
