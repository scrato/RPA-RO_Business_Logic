using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Model.Security;
using RPA.Core;
using RPA.Data.Security;

namespace RPA.Business.Security
{
    public class UserValidator : Validator<User>
    {
        public UserValidator(IAppContext appContext)
            : base(appContext)
        {
            
        }

        protected override void OnValidate(ValidationInfo info, User item)
        {
            base.OnValidate(info, item);
            if (String.IsNullOrEmpty(item.Name))
                info.AddError("Name", "Name is null or empty");
            var userRep = AppContext.GetObject<IUserRepository>();
            var user = userRep.GetByName(item.Name);
            if (user != null && user.Id != item.Id)
                info.AddError("Name", "Name is not unique");
        }
    }
}
