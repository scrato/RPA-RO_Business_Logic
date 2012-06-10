namespace RPA.Client.Forms
{
    partial class FrameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exRibbon = new RPA.Client.Forms.Core.Ribbon.ExRibbon();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exRibbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // exRibbon
            // 
            this.exRibbon.Controls.Add(this.tabPage1);
            this.exRibbon.Controls.Add(this.tabPage2);
            this.exRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.exRibbon.Location = new System.Drawing.Point(0, 0);
            this.exRibbon.Name = "exRibbon";
            this.exRibbon.SelectedIndex = 0;
            this.exRibbon.Size = new System.Drawing.Size(944, 112);
            this.exRibbon.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 536);
            this.Controls.Add(this.exRibbon);
            this.Name = "FrameForm";
            this.Text = "RPA Client 0.0.0.1";
            this.Load += new System.EventHandler(this.FrameForm_Load);
            this.exRibbon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Ribbon.ExRibbon exRibbon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}

