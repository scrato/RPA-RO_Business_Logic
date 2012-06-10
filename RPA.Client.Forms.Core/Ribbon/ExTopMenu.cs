using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RPA.Client.Forms.Core.Frames
{
    public class ExTopMenu : ExPanel
    {
        private int nexticon = 5;
        public ExTopMenu()
        {
            this.Dock = DockStyle.Top;
            this.Height = 70;
        }

        public void AddIconButton(ExIconButton button)
        {
            button.Location = new Point(nexticon, 5);
            this.Controls.Add(button);
            nexticon += 69;
            base.Refresh();
        }
    
    }
}
