using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using RPA.Core;

namespace RPA.Application.Security
{
    public class SignInFailedException : UserException
    {
        public SignInFailedException()
        {

        }
        public SignInFailedException(string message)
            : base(message)
        {

        }
        public SignInFailedException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        protected SignInFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
