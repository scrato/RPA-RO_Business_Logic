using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace RPA.Core
{
    public enum RegistrationMode
    {
        CreateAlways,
        CreateOnce
    }

    public enum ControlMode
    {
        ContainerControlled,
        ExternallyControlled
    }

    public interface IAppContext : IDisposable
    {
        IPrincipal User { get; set; }
        void AddObject<I>(I obj);
        void AddObject<I>(I obj, ControlMode mode);
        void AddType<I, T>() where T : I;
        void AddType<I, T>(RegistrationMode mode) where T : I;
        I GetObject<I>();    }
}
