using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPA.Client.Forms.Core.Ribbon;
using RPA.Presentation;
using System.Resources;
using RPA.Client.Forms.Core;

namespace RPA.Client.Forms
{
    public partial class FrameForm : ExForm
    {
        public FrameForm()
        {
            InitializeComponent();
            exRibbon.TabPages.Clear();

            ExRibbonTab startTab = new ExRibbonTab();
            exRibbon.AddRibbonTab(startTab);

            ExRibbonButton button_warrior = new ExRibbonButton(RPA.Presentation.Properties.Resources.warrior);
            ExRibbonButton button_rogue = new ExRibbonButton(RPA.Presentation.Properties.Resources.rogue);

            startTab.AddRibbonButton(button_warrior);
            startTab.AddRibbonButton(button_rogue);


        }

        private void FrameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
