using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TES3MP_GUI
{
    /*
     * @auth: Michael Kellam
     * @email: michaelkellamcs@gmail.com
     * @github: github.com/michaelkellam-cs
     * 
     * Welcome to my TES3MP Server Manager. This is still a work in progress and
     * done on my freetime, so my updates may be fairly intermittent.
     * There may be a few bugs and unfinished parts, but I'm working on bringing 
     * new features and increasing stability.
     */
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Application.Run();
        }

        public static void CreatePortal()
        {
            PortalForm pf = new PortalForm();
        }
    }
}
