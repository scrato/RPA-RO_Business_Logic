using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using RPA.Core;
using RPA.Data;

namespace RPA.Business
{
    public class UnitOfWorkWasNotCompletedException : UserException
    {
        public UnitOfWorkWasNotCompletedException()
        {
            
        }
        public UnitOfWorkWasNotCompletedException(string message)
            : base(message)
        {
            
        }
        public UnitOfWorkWasNotCompletedException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        protected UnitOfWorkWasNotCompletedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            
        }
    }
}
