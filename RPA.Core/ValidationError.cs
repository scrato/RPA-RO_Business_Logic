using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Core
{
    public sealed class ValidationError
    {
        public ValidationError(string propertyName, string text)
        {
            PropertyName = propertyName;
            Text = text;
        }

        public string PropertyName { get; private set; }
        public string Text { get; private set; }
    }
}
