namespace RPA.Client.Forms
{
    partial class SplashForm
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
            this._panelAction = new RPA.Client.Forms.Core.ExPanel();
            this._signInView = new RPA.Client.Forms.Security.SignInView();
            this._panelAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelAction
            // 
            this._panelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._panelAction.Controls.Add(this._signInView);
            this._panelAction.Location = new System.Drawing.Point(88, 88);
            this._panelAction.Name = "_panelAction";
            this._panelAction.Size = new System.Drawing.Size(300, 200);
            this._panelAction.TabIndex = 7;
            // 
            // _signInView
            // 
            this._signInView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._signInView.Location = new System.Drawing.Point(0, 0);
            this._signInView.Name = "_signInView";
            this._signInView.Size = new System.Drawing.Size(300, 200);
            this._signInView.TabIndex = 0;
            this._signInView.StateChanged += new System.EventHandler(this.SignInView_StateChanged);
            // 
            // SplashView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this._panelAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPA Client 0.0.0.1";
            this._panelAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Core.ExPanel _panelAction;
        private Security.SignInView _signInView;
    }
}