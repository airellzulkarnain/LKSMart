using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login_session: 
            Login login = new Login();
            Application.Run(login);
            if (login.customer_id != 0)
            {
                Main main = new Main(login.customer_id);
                Application.Run(main);
                if (main.DialogResult == DialogResult.Cancel)
                {
                    login.Dispose();
                    main.Dispose();
                    goto login_session;
                }
            }
        }
    }
}
