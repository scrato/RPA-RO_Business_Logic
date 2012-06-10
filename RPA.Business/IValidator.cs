using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model;
using RPA.Core;

namespace RPA.Business
{
    public interface IValidator<T> : IServiceBase where T : Entity
    {
        ValidationInfo Validate(T item);
    }
}
