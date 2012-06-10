namespace RPA.Client.Forms.Security
{
    partial class SignInView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._linkLabelCreateUser = new RPA.Client.Forms.Core.ExLinkLabel();
            this._buttonCancel = new RPA.Client.Forms.Core.ExButton();
            this._buttonSignIn = new RPA.Client.Forms.Core.ExButton();
            this._textBoxPassword = new RPA.Client.Forms.Core.ExTextBox();
            this._labelPassword = new RPA.Client.Forms.Core.ExLabel();
            this._textBoxName = new RPA.Client.Forms.Core.ExTextBox();
            this._labelName = new RPA.Client.Forms.Core.ExLabel();
            this.SuspendLayout();
            // 
            // _linkLabelCreateUser
            // 
            this._linkLabelCreateUser.AutoSize = true;
            this._linkLabelCreateUser.Location = new System.Drawing.Point(116, 81);
            this._linkLabelCreateUser.Name = "_linkLabelCreateUser";
            this._linkLabelCreateUser.Size = new System.Drawing.Size(126, 13);
            this._linkLabelCreateUser.TabIndex = 6;
            this._linkLabelCreateUser.TabStop = true;
            this._linkLabelCreateUser.Text = "Neuen Benutzer erstellen";
            this._linkLabelCreateUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCreateUser_LinkClicked);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(200, 55);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 5;
            this._buttonCancel.Text = "Abbrechen";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // _buttonSignIn
            // 
            this._buttonSignIn.Location = new System.Drawing.Point(119, 55);
            this._buttonSignIn.Name = "_buttonSignIn";
            this._buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this._buttonSignIn.TabIndex = 4;
            this._buttonSignIn.Text = "Anmelden";
            this._buttonSignIn.UseVisualStyleBackColor = true;
            this._buttonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Location = new System.Drawing.Point(119, 29);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.PasswordChar = '*';
            this._textBoxPassword.Size = new System.Drawing.Size(178, 20);
            this._textBoxPassword.TabIndex = 3;
            // 
            // _labelPassword
            // 
            this._labelPassword.Location = new System.Drawing.Point(3, 32);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(110, 13);
            this._labelPassword.TabIndex = 2;
            this._labelPassword.Text = "Passwort";
            this._labelPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(119, 3);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(178, 20);
            this._textBoxName.TabIndex = 1;
            // 
            // _labelName
            // 
            this._labelName.Location = new System.Drawing.Point(3, 6);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(110, 13);
            this._labelName.TabIndex = 0;
            this._labelName.Text = "Benutzer";
            this._labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SignInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._linkLabelCreateUser);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSignIn);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this._labelName);
            this.Name = "SignInView";
            this.Size = new System.Drawing.Size(300, 200);
            this.Enter += new System.EventHandler(this.SignInView_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.ExLinkLabel _linkLabelCreateUser;
        private Core.ExButton _buttonCancel;
        private Core.ExButton _buttonSignIn;
        private Core.ExTextBox _textBoxPassword;
        private Core.ExLabel _labelPassword;
        private Core.ExTextBox _textBoxName;
        private Core.ExLabel _labelName;
    }
}
