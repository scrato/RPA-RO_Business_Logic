using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Core
{
    public sealed class ValidationInfo
    {
        public ValidationInfo()
        {
            Errors = new List<ValidationError>();
        }

        public List<ValidationError> Errors { get; private set; }

        public bool IsValid
        {
            get { return Errors.Count == 0; }
        }

        public void AddError(string propertyName, string text)
        {
            Errors.Add(new ValidationError(propertyName, text));
        }
    }
}
