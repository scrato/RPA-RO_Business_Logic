using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RPA.Client.Forms.Core.Ribbon
{
    public class ExRibbonTab : TabPage
    {
        private int nexticon = 5;

        public void AddRibbonButton(ExRibbonButton button)
        {
            button.Location = new Point(nexticon, 5);
            this.Controls.Add(button);
            nexticon += 69;
            base.Refresh();
        }
    
    }
}
