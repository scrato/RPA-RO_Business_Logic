using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RPA.Core;
using RPA.Application;
using RPA.Application.Security;

namespace RPA.Client.Forms
{
    static class Program
    {
        public static IAppContext AppContext { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.DoEvents();
            using (var appContext = new AppContext())
            {
                // Globaler Context
                AppContext = appContext;
                
                // Initialisierung
                using (var splash = new SplashForm())
                {
                    if (splash.ShowDialog() == DialogResult.OK)
                    {
                        System.Windows.Forms.Application.Run(new FrameForm());
                    }
                }
            }
        }
    }
}
