using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;
using System.Runtime.Serialization;

namespace RPA.Application.Security
{
    public class CreateAccountFailedException : UserException
    {
        public CreateAccountFailedException()
        {
            
        }
        public CreateAccountFailedException(string message)
            : base(message)
        {
            
        }
        public CreateAccountFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        protected CreateAccountFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            
        }
    }
}
