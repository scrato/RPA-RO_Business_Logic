using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RPA.Application.Security;
using RPA.Client.Forms.Core;

namespace RPA.Client.Forms.Security
{
    public enum SignInState
    {
        None,
        Completed,
        Canceled,
        CreateAccountRequested
    }

    public partial class SignInView : ExUserControl
    {
        public event EventHandler StateChanged;

        public SignInView()
        {
            InitializeComponent();
            State = SignInState.None;
        }


        public SignInState State { get; private set; }

        private void ChangeState(SignInState state)
        {
            State = state;
            if (StateChanged != null)
            {
                StateChanged(this, new EventArgs());
            }
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var security = Program.AppContext.GetObject<ISecurityService>();
                security.SignIn(_textBoxName.Text, _textBoxPassword.Text);
                ChangeState(SignInState.Completed);
            }
            catch (SignInFailedException)
            {
                MessageBox.Show("Anmeldung fehlgeschlagen.", "Meldung");
                _textBoxPassword.Text = string.Empty;
                _textBoxPassword.Focus();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ChangeState(SignInState.Canceled);
        }

        private void LinkLabelCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeState(SignInState.CreateAccountRequested);
        }


        private void SignInView_Enter(object sender, EventArgs e)
        {
            var form = FindForm();
            form.AcceptButton = _buttonSignIn;
            form.CancelButton = _buttonCancel;
        }
    }
}
