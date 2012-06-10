using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPA.Core;

namespace RPA.Client.Forms.Core.Components
{
    public partial class ExErrorManager : Component
    {
        public ExErrorManager()
        {
            InitializeComponent();
        }

        public ExErrorManager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public BindingsCollection Bindings { get; set; }
        
        public Control FindControl(String propertyName)
        {
            for (var i = 0; i < Bindings.Count; i++)
            {
                if (Bindings[i].BindingMemberInfo.BindingField == propertyName)
                    return Bindings[i].Control;
            }
            return null;
        }

        public void Clear()
        {
            _errorProvider.Clear();
        }

        public void SetError(Control control, string text)
        {
            _errorProvider.SetError(control, text);
        }

        public void SetErrors(ValidationInfo info)
        {
            foreach (var error in info.Errors)
            {
                var control = FindControl(error.PropertyName);
                if (control != null)
                    SetError(control, error.Text);
            }
        }
    }
}
