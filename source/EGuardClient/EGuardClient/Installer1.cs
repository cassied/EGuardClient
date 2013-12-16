using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Linq;
using System.Data;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Windows.Forms;

namespace EGuardClient
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
         public Installer1()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary savedState)
        {
            base.Install(savedState);
            
            // Install EGuardClient windows service
            EGuardClientService.Framework.WindowsServiceInstaller.RuntimeInstall<EGuardClientService.ServiceImplementation>();
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
            //Add custom code here
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            //Add custom code here
        }

        public override void Uninstall(IDictionary savedState)
        {
            string message = string.Empty;
            Int32 count = 0;

            SqlCeConnection con = new SqlCeConnection();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\EGuard.sdf; Persist Security Info=False;";
            string connection = "Data Source=" + path.Substring(6, path.Length - 6);
            con.ConnectionString = connection;

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;


            List<string> promptValue = EGuardClient.Prompt.ShowDialog("User Name", "Password", "Uninstallation Credential Validation");
            cmd.CommandText = "SELECT COUNT(*) FROM UserRec WHERE Username='" + promptValue[0].ToString() + "' AND Password = '" + promptValue[1].ToString() + "';";
            try
            {
                con.Open();
                count = (Int32)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Uninstallation will proceed.");
                }
                else
                {
                    MessageBox.Show("You do not have permissions to uninstall this application.");
                    throw new UnauthorizedAccessException();

                }

            }
            catch (SqlCeException ex)
            {
                message = ex.Message.ToString();
                MessageBox.Show(message.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();

            }


            Process application = null;
            foreach (var process in Process.GetProcesses())
            {
                if (!process.ProcessName.ToLower().Contains("EGuardClient")) continue;
                application = process;
                break;
            }

            if (application != null && application.Responding)
            {
                application.Kill();
                base.Uninstall(savedState);
            }

            // Uninstall windows service
            EGuardClientService.Framework.WindowsServiceInstaller.RuntimeUnInstall<EGuardClientService.ServiceImplementation>();

        }

    }
}
