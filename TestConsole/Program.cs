using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using RPA.Application;
using RPA.Application.Security;
using RPA.Business;
using RPA.Core;
using RPA.Data;
using RPA.Data.Security;
using RPA.Model.Security;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var appContext = new AppContext())
            {
                var securityServ = appContext.GetObject<ISecurityService>();
                using (var uow = appContext.GetObject<IUnitOfWork>())
                {
                    using (var uow1 = appContext.GetObject<IUnitOfWork>())
                    {
                        securityServ.CreateAccount(new CreateAccountInfo() { Name = "Michael", Password = "neu" });
                        securityServ.CreateAccount(new CreateAccountInfo() { Name = "Roland", Password = "neu" });
                        uow1.Complete();
                    }
                    using (var uow2 = appContext.GetObject<IUnitOfWork>())
                    {
                        securityServ.CreateAccount(new CreateAccountInfo() { Name = "Steffen", Password = "neu" });
                        securityServ.CreateAccount(new CreateAccountInfo() { Name = "Erik", Password = "neu" });
                        securityServ.CreateAccount(new CreateAccountInfo() { Name = "Frank", Password = "neu" });
                        using (var uow21 = appContext.GetObject<IUnitOfWork>())
                        {
                            securityServ.CreateAccount(new CreateAccountInfo() { Name = "Dennis", Password = "neu" });
                            securityServ.CreateAccount(new CreateAccountInfo() { Name = "Dimitri", Password = "neu" });
                            securityServ.CreateAccount(new CreateAccountInfo() { Name = "Christian", Password = "neu" });
                            uow21.Complete();
                        }
                        uow2.Complete();
                    }
                    using (var uow3 = appContext.GetObject<IUnitOfWork>())
                    {
                        securityServ.CreateAccount(new CreateAccountInfo() { Name = "Robert", Password = "neu" });
                        uow3.Complete();
                    }
                    uow.Complete();
                }
                foreach (var item in appContext.GetObject<IUserRepository>())
                {
                    Console.WriteLine(item);
                }
            }
            PressAnyKeyToExit();
        }

        private static void PressAnyKeyToExit()
        {
            Console.ReadKey();
        }
    }
}
