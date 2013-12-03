using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlServerCe;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;

namespace EGuardClient
{
    public static class SuggestedURLDB
    {
        private const string conStr = "Data Source=|DataDirectory|\\EGuard.sdf; Persist Security Info=False;";

        public static List<SuggestedURL> GetSuggestedURLs()
        {
          
            List<SuggestedURL> suggestedurls = new List<SuggestedURL>();

            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            //Exclude Suggested URLs that are already being blocked
            cmd.CommandText = "SELECT URL FROM URLs LEFT OUTER JOIN BlockedURLCat B ON B.BlockedURL=URLs.URL WHERE Category='URL' AND B.BlockedURL IS NULL ORDER BY URL;";
            
            cmd.Connection = connection;

            cmd.Connection.Open();
            SqlCeDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SuggestedURL suggestedurl = new SuggestedURL();
                suggestedurl.suggestedURL = rdr.GetValue(0).ToString();
                suggestedurls.Add(suggestedurl);
            }

            cmd.Connection.Close();
            cmd.Connection.Dispose();
            cmd.Dispose();
            return suggestedurls;



        }

        public static void SaveSuggestedURLs(List<SuggestedURL> suggestedurls)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String url = string.Empty;

            try
            {
                cmd.Connection.Open();
                foreach (SuggestedURL u in suggestedurls)
                {

                    //cmd.CommandText = "INSERT INTO URL (BlockedURL) VALUES ('" + u.blockedURL.ToString() + "');";
                    //cmd.ExecuteNonQuery();
                   // MessageBox.Show(cmd.CommandText.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
