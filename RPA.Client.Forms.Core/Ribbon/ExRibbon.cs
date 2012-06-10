using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPA.Client.Forms.Core.Ribbon
{
    public class ExRibbon : TabControl
    {
        
        public ExRibbon()
        {
            this.Dock = DockStyle.Top;
            this.Height = 70;
        }

        public void AddRibbonTab(ExRibbonTab tab)
        {
            this.Controls.Add(tab);
        }
    }
}
