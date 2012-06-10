using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace RPA.Client.Forms.Core
{
    public class ExErrorProvider : ErrorProvider
    {
        public ExErrorProvider()
        {
            
        }
        public ExErrorProvider(ContainerControl parentControl)
            : base(parentControl)
        {
            
        }
        public ExErrorProvider(IContainer container)
            : base(container)
        {
            
        }
    }
}
