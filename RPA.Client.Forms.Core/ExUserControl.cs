using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPA.Client.Forms.Core.Components;

namespace RPA.Client.Forms.Core
{
    public partial class ExUserControl : UserControl
    {
        public ExUserControl()
        {
            InitializeComponent();
        }

        protected ExErrorManager ErrorManager
        {
            get { return _errorManager; }
        }
    }
}
