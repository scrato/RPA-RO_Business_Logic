using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using RPA.Core;
using RPA.Model.Security;
using RPA.Data.Security;
using RPA.Business;

namespace RPA.Application.Security
{
    public class SecurityService : ServiceBase, ISecurityService
    {
        public SecurityService(IAppContext appContext)
            : base(appContext)
        {

        }

        public void SignIn(string name, string password)
        {
            var users = AppContext.GetObject<IUserRepository>();
            var user = users.GetByName(name);
            if (user != null && string.Compare(user.Password, password, false) == 0)
            {
                AppContext.User = new GenericPrincipal(
                    new GenericIdentity(user.Name), 
                    new string[] { "Administrators", "Users" });
                return;
            }
            throw new SignInFailedException();
        }

        public void CreateAccount(CreateAccountInfo item)
        {
            try
            {
                var user = User.Create(item.Name, item.Password);
                user.Profile.FirstName = item.FirstName;
                user.Profile.LastName = item.LastName;
                var info = AppContext
                    .GetObject<IValidator<User>>()
                    .Validate(user);
                if (!info.IsValid)
                    throw new ValidationException(info);
                using (var uow = AppContext.GetObject<IUnitOfWork>())
                {
                    AppContext
                        .GetObject<IUserRepository>()
                        .Add(user);
                    uow.Complete();
                }
                AppContext.User = new GenericPrincipal(
                    new GenericIdentity(item.Name),
                    new string[] { });
            }
            catch (UserException ex)
            {
                throw new CreateAccountFailedException(ex.Message, ex);
            }
        }
    }
}
