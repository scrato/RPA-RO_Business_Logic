using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;
using System.Security.Principal;
using System.Runtime.Serialization;

namespace RPA.Application.Security
{
    public interface ISecurityService : IServiceBase
    {
        void SignIn(string name, string password);
        void CreateAccount(CreateAccountInfo item);
    }
}
