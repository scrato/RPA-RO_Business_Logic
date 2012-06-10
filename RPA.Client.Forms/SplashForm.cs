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
using RPA.Client.Forms.Security;

namespace RPA.Client.Forms
{
    public partial class SplashForm : Form
    {
        private CreateAccountView _createAccountView;

        public SplashForm()
        {
            InitializeComponent();
            _createAccountView = new CreateAccountView();
            _createAccountView.Dock = DockStyle.Fill;
            _createAccountView.StateChanged += new EventHandler(CreateAccountView_StateChanged);
        }

        private void CreateAccountView_StateChanged(object sender, EventArgs e)
        {
            switch (_createAccountView.State)
            {
                case CreateAccountState.Completed:
                    DialogResult = DialogResult.OK;
                    Close(); 
                    break;
                case CreateAccountState.Canceled:
                    _panelAction.Controls.Remove(_createAccountView);
                    _panelAction.Controls.Add(_signInView);
                    break;
            }
        }

        private void SignInView_StateChanged(object sender, EventArgs e)
        {
            switch (_signInView.State)
            {
                case SignInState.Completed:
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case SignInState.Canceled:
                    DialogResult = DialogResult.Cancel;
                    Close();
                    break;
                case SignInState.CreateAccountRequested:
                    _panelAction.Controls.Remove(_signInView);
                    _panelAction.Controls.Add(_createAccountView);
                    break;
            }
        }
    }
}
