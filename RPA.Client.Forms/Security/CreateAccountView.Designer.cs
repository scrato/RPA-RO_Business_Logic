namespace RPA.Client.Forms.Security
{
    partial class CreateAccountView
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
            this._textBoxRepeatPassword = new RPA.Client.Forms.Core.ExTextBox();
            this._labelRepeatPassword = new RPA.Client.Forms.Core.ExLabel();
            this._buttonCancel = new RPA.Client.Forms.Core.ExButton();
            this._buttonCreateAccount = new RPA.Client.Forms.Core.ExButton();
            this._textBoxLastName = new RPA.Client.Forms.Core.ExTextBox();
            this._labelLastName = new RPA.Client.Forms.Core.ExLabel();
            this._textBoxFirstName = new RPA.Client.Forms.Core.ExTextBox();
            this._labelFirstName = new RPA.Client.Forms.Core.ExLabel();
            this._textBoxPassword = new RPA.Client.Forms.Core.ExTextBox();
            this._labelPassword = new RPA.Client.Forms.Core.ExLabel();
            this._textBoxName = new RPA.Client.Forms.Core.ExTextBox();
            this._labelName = new RPA.Client.Forms.Core.ExLabel();
            this.SuspendLayout();
            // 
            // _textBoxRepeatPassword
            // 
            this._textBoxRepeatPassword.Location = new System.Drawing.Point(119, 55);
            this._textBoxRepeatPassword.Name = "_textBoxRepeatPassword";
            this._textBoxRepeatPassword.PasswordChar = '*';
            this._textBoxRepeatPassword.Size = new System.Drawing.Size(160, 20);
            this._textBoxRepeatPassword.TabIndex = 5;
            // 
            // _labelRepeatPassword
            // 
            this._labelRepeatPassword.Location = new System.Drawing.Point(3, 58);
            this._labelRepeatPassword.Name = "_labelRepeatPassword";
            this._labelRepeatPassword.Size = new System.Drawing.Size(110, 13);
            this._labelRepeatPassword.TabIndex = 4;
            this._labelRepeatPassword.Text = "Passwort wiederholen";
            this._labelRepeatPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(200, 133);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 11;
            this._buttonCancel.Text = "&Abbrechen";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // _buttonCreateAccount
            // 
            this._buttonCreateAccount.Location = new System.Drawing.Point(119, 133);
            this._buttonCreateAccount.Name = "_buttonCreateAccount";
            this._buttonCreateAccount.Size = new System.Drawing.Size(75, 23);
            this._buttonCreateAccount.TabIndex = 10;
            this._buttonCreateAccount.Text = "&Erstellen";
            this._buttonCreateAccount.UseVisualStyleBackColor = true;
            this._buttonCreateAccount.Click += new System.EventHandler(this.ButtonCreateAccount_Click);
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(119, 107);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(160, 20);
            this._textBoxLastName.TabIndex = 9;
            // 
            // _labelLastName
            // 
            this._labelLastName.Location = new System.Drawing.Point(3, 110);
            this._labelLastName.Name = "_labelLastName";
            this._labelLastName.Size = new System.Drawing.Size(110, 13);
            this._labelLastName.TabIndex = 8;
            this._labelLastName.Text = "Nachname";
            this._labelLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(119, 81);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(160, 20);
            this._textBoxFirstName.TabIndex = 7;
            // 
            // _labelFirstName
            // 
            this._labelFirstName.Location = new System.Drawing.Point(3, 84);
            this._labelFirstName.Name = "_labelFirstName";
            this._labelFirstName.Size = new System.Drawing.Size(110, 13);
            this._labelFirstName.TabIndex = 6;
            this._labelFirstName.Text = "Vorname";
            this._labelFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Location = new System.Drawing.Point(119, 29);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.PasswordChar = '*';
            this._textBoxPassword.Size = new System.Drawing.Size(160, 20);
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
            this._textBoxName.Size = new System.Drawing.Size(160, 20);
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
            // CreateAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxRepeatPassword);
            this.Controls.Add(this._labelRepeatPassword);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonCreateAccount);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this._labelLastName);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this._labelFirstName);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this._labelName);
            this.Name = "CreateAccountView";
            this.Size = new System.Drawing.Size(300, 200);
            this.Enter += new System.EventHandler(this.CreateAccountView_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.ExLabel _labelName;
        private Core.ExTextBox _textBoxName;
        private Core.ExLabel _labelPassword;
        private Core.ExTextBox _textBoxPassword;
        private Core.ExLabel _labelFirstName;
        private Core.ExTextBox _textBoxFirstName;
        private Core.ExLabel _labelLastName;
        private Core.ExTextBox _textBoxLastName;
        private Core.ExButton _buttonCreateAccount;
        private Core.ExButton _buttonCancel;
        private Core.ExTextBox _textBoxRepeatPassword;
        private Core.ExLabel _labelRepeatPassword;
    }
}
