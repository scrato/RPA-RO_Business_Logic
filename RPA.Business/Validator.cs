using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model;
using RPA.Core;

namespace RPA.Business
{
    public class Validator<T> : ServiceBase, IValidator<T> where T : Entity
    {
        public Validator(IAppContext appContext)
            : base(appContext)
        {
            
        }

        public ValidationInfo Validate(T item)
        {
            var info = new ValidationInfo();
            OnValidate(info, item);
            return info;
        }

        protected virtual void OnValidate(ValidationInfo info, T item)
        {
            if (item.Id == Guid.Empty)
                info.AddError("Id", "Id is empty.");
        }
    }
}
