using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scada
{
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
            Application.Run(new Register());
            //Application.Run(new SCADA());
            //Application.Run(new FormAuto());
            //Application.Run(new Error());
            //Application.Run(new Manual());
        }
    }
}
