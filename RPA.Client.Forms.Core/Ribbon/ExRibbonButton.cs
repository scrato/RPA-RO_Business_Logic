using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RPA.Client.Forms.Core.Ribbon
{
    public class ExRibbonButton : ExButton
    {

        public ExRibbonButton(Icon icon)
        {
            this.ImageList = new ImageList();
            this.ImageList.Images.Add(icon);
            this.ImageIndex = 0;
            this.Size = new Size(64, 64);
            
        }
            
    }
}
