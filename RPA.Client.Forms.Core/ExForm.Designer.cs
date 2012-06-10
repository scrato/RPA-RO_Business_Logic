namespace RPA.Client.Forms.Core
{
    partial class ExForm
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
            this.components = new System.ComponentModel.Container();
            this._errorManager = new RPA.Client.Forms.Core.Components.ExErrorManager(this.components);
            this.SuspendLayout();
            // 
            // _errorManager
            // 
            this._errorManager.Bindings = null;
            // 
            // ExForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "ExForm";
            this.Text = "FormView";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ExErrorManager _errorManager;
    }
}