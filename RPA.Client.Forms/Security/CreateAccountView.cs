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
using RPA.Core;

namespace RPA.Client.Forms.Security
{
    public enum CreateAccountState
    {
        None,
        Completed,
        Canceled
    }

    public partial class CreateAccountView : ExUserControl
    {
        public event EventHandler StateChanged;

        public CreateAccountView()
        {
            InitializeComponent();
            State = CreateAccountState.None;
            Model = new CreateAccountInfo();
            SetDataBindings();
        }

        public CreateAccountState State { get; private set; }
        public CreateAccountInfo Model { get; private set; }

        private void SetDataBindings()
        {
            ErrorManager.Bindings = BindingContext[Model].Bindings;
            _textBoxName.DataBindings.Clear();
            _textBoxName.DataBindings.Add("Text", Model, "Name");
            _textBoxPassword.DataBindings.Clear();
            _textBoxPassword.DataBindings.Add("Text", Model, "Password");
            _textBoxFirstName.DataBindings.Clear();
            _textBoxFirstName.DataBindings.Add("Text", Model, "FirstName");
            _textBoxLastName.DataBindings.Clear();
            _textBoxLastName.DataBindings.Add("Text", Model, "LastName");
        }

        private void ChangeState(CreateAccountState state)
        {
            State = state;
            if (StateChanged != null)
                StateChanged(this, new EventArgs());
        }

        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            ErrorManager.Clear();
            if (string.Compare(_textBoxPassword.Text, _textBoxRepeatPassword.Text, false) != 0)
            {
                ErrorManager.SetError(_textBoxRepeatPassword, "Die Passwörter stimmen nicht überein.");
                return;
            }
            try
            {
                Program.AppContext
                    .GetObject<ISecurityService>()
                    .CreateAccount(Model);
                ChangeState(CreateAccountState.Completed);
            }
            catch(CreateAccountFailedException ex)
            {
                var vex = ex.InnerException as ValidationException;
                if (vex != null)
                    ErrorManager.SetErrors(vex.Info);
                else
                  MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ErrorManager.Clear();
            ChangeState(CreateAccountState.Canceled);
        }

        private void CreateAccountView_Enter(object sender, EventArgs e)
        {
            var form = FindForm();
            form.AcceptButton = _buttonCreateAccount;
        }
    }
}
