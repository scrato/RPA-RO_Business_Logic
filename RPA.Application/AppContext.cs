using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Practices.Unity;
using RPA.Application.Security;
using RPA.Core;
using RPA.Data.Security;
using RPA.Data;
using RPA.Business;
using RPA.Model.Security;
using RPA.Business.Security;

namespace RPA.Application
{
    public class AppContext : DisposableObject, IAppContext
    {
        private IUnityContainer _container;

        public AppContext()
        {
            _container = new UnityContainer();
            User = new WindowsPrincipal(WindowsIdentity.GetAnonymous());
            InitializeContainer(_container);

            if (SessionHelper.flushSchema)
           {
                var service = this.GetObject<ISecurityService>();
                var debugAccount = new CreateAccountInfo();
                debugAccount.LastName = "Administrator";
                debugAccount.Name = "Admin";
                debugAccount.Password = "123";
                service.CreateAccount(debugAccount);
            }

        }

        public IPrincipal User
        {
            get { return Thread.CurrentPrincipal; }
            set { Thread.CurrentPrincipal = value; }
        }

        protected virtual void InitializeContainer(IUnityContainer container)
        {
            // General
            AddObject<IAppContext>(this);
            // Data
            AddType<IDataContext, DataContext>(RegistrationMode.CreateOnce);
            AddType<IUserRepository, UserRepository>(RegistrationMode.CreateOnce);
            // Business
            AddType<IUnitOfWorkManager, UnitOfWorkManager>(RegistrationMode.CreateOnce);
            AddType<IUnitOfWork, UnitOfWork>(RegistrationMode.CreateAlways);
            // Validation
            AddType<IValidator<User>, UserValidator>(RegistrationMode.CreateOnce);
            // Application
            AddType<ISecurityService, SecurityService>(RegistrationMode.CreateOnce);
        }


        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                _container.Dispose();
            }
            base.Dispose(isDisposing);
        }

        public void AddObject<I>(I obj)
        {
            AddObject<I>(obj, ControlMode.ExternallyControlled);
        }

        public void AddObject<I>(I obj, ControlMode mode)
        {
            switch (mode)
            {
                case ControlMode.ExternallyControlled:
                    _container.RegisterInstance<I>(obj, new ExternallyControlledLifetimeManager());
                    break;
                case ControlMode.ContainerControlled:
                    _container.RegisterInstance<I>(obj, new ContainerControlledLifetimeManager());
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public void AddType<I, T>() where T : I
        {
            AddType<I, T>(RegistrationMode.CreateAlways);
        }

        public void AddType<I, T>(RegistrationMode mode) where T : I
        {
            switch (mode)
            {
                case RegistrationMode.CreateAlways:
                    _container.RegisterType<I, T>();
                    break;
                case RegistrationMode.CreateOnce:
                    _container.RegisterType<I, T>(new ContainerControlledLifetimeManager());
                    break;
                default:
                    throw new NotSupportedException();
            }
        }


        public I GetObject<I>()
        {
            return _container.Resolve<I>();
        }
    }
}
