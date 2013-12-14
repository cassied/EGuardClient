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
using System.Text.RegularExpressions;

namespace EGuardClient
{
    public static class BlockedURLDB
    {
        private const string conStr = "Data Source=|DataDirectory|\\EGuard.sdf";

        public static List<BlockedURL> GetBlockedURLs()
        {
          
            List<BlockedURL> blockedurls = new List<BlockedURL>();
 
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT BlockedURL+'-'+BlockedCat FROM BlockedURLCat WHERE BlockedURL IS NOT NULL ORDER BY BlockedURL;";
            
            cmd.Connection = connection;

            cmd.Connection.Open();
            SqlCeDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())  
            {

                BlockedURL blockedurl = new BlockedURL();
                blockedurl.blockedURL = rdr.GetValue(0).ToString();
                blockedurls.Add(blockedurl);
            }                                                                                                                                                                                                                   

            cmd.Connection.Close();
            cmd.Connection.Dispose();
            cmd.Dispose();
            return blockedurls;



        }

        public static void DeleteBlockedURL(BlockedURL u)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String url = string.Empty;
            String cat = string.Empty;

            try
            {
                string[] values = u.blockedURL.ToString().Split('-');
                url = values[0];
                cat = values[1];
                
                cmd.Connection.Open();
                cmd.CommandText = "DELETE FROM BlockedURLCat WHERE BlockedURL='" + url + "';";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        public static void SaveBlockedURL(BlockedURL u)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String url = string.Empty;
            String cat = string.Empty;

            try
            {
                cmd.Connection.Open();
                string[] values = u.blockedURL.ToString().Split('-');
                url = values[0];
                cat = values[1];
                url = url.Replace("www.", "");
                url = url.Replace("http://", "");

                cmd.CommandText = "INSERT INTO BlockedURLCat (BlockedURL,BlockedCat) VALUES ('" + url + "','" + cat + "');";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());


            }
               
          }

        public static void SaveBlockedURLs(List<BlockedURL> blockedurls)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String url = string.Empty;
            String cat = string.Empty;
            string[] values;

            try
            {
                cmd.Connection.Open();
                //cmd.CommandText = "DELETE FROM BlockedURLCat WHERE BlockedURL IS NOT NULL;";
                //cmd.ExecuteNonQuery();

                foreach (BlockedURL u in blockedurls)
                {
                    values = u.blockedURL.ToString().Split('-');

                    cmd.CommandText = "INSERT INTO BlockedURLCat (BlockedURL,BlockedCat) VALUES ('" + url + "'," + cat + "');";                
                    cmd.ExecuteNonQuery();
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
               
          }

    }
}
