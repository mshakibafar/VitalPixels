using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] argv)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FSplash fs = new FSplash();
            fs.Show();
            if (argv.Length > 0)
                Application.Run(new MDIMainForm(argv,fs));
            else
                Application.Run(new MDIMainForm(fs));
            
        }
    }
}
