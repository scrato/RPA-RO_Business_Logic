using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RPA.Core
{
    public class UserException : ApplicationException
    {
        public UserException()
        {
            
        }
        public UserException(string message)
            : base(message)
        {
            
        }
        public UserException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        protected UserException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            
        }
    }
}
