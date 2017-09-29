using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball2text
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

            Thread loggerForm = new Thread(LoggerStart);
            loggerForm.Start();

            Application.Run(new Form1());
        }

        private static void LoggerStart()
        {
            Application.Run(new VideoLoggerForm());
        }
    }
}
