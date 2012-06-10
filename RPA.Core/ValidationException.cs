using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RPA.Core
{
    public class ValidationException : UserException
    {
        public ValidationException()
        {
            
        }
        public ValidationException(string message)
            : base(message)
        {
            
        }
        public ValidationException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        protected ValidationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            
        }
        public ValidationException(ValidationInfo info)
            : this()
        {
            Info = info;
        }
        public ValidationException(string message, ValidationInfo info)
            : this(message)
        {
            Info = info;
        }

        public ValidationInfo Info { get; set; }
    }
}
