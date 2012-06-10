using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Core
{
    public class ServiceBase : DisposableObject, IServiceBase
    {
        public ServiceBase(IAppContext appContext)
        {
            AppContext = appContext;
        }

        public IAppContext AppContext { get; private set; }
    }
}
