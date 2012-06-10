using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RPA.Client.Forms.Core
{
    public partial class ExIconButton : ExButton
    {
        public ExIconButton(Icon icon)
        {
            InitializeComponent();
            this.ImageList = new ImageList();
            this.ImageList.Images.Add(icon);
            this.ImageIndex = 0;
            this.Size = new Size(64, 64);
            
        }

    }
}
