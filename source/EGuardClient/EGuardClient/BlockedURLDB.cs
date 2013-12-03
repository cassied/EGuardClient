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
    public static class BlockedURLDB
    {
        private const string conStr = "Data Source=|DataDirectory|\\EGuard.sdf";

        public static List<BlockedURL> GetBlockedURLs()
        {
          
            List<BlockedURL> blockedurls = new List<BlockedURL>();

            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT BlockedURL FROM BlockedURLCat WHERE BlockedURL IS NOT NULL ORDER BY BlockedURL;";
            
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

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "DELETE FROM BlockedURLCat WHERE BlockedURL='" + u.blockedURL + "';";
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

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "INSERT INTO BlockedURLCat (BlockedURL,BlockedCat) VALUES ('" + u.blockedURL + "', null);";                
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

            try
            {
                cmd.Connection.Open();
                //cmd.CommandText = "DELETE FROM BlockedURLCat WHERE BlockedURL IS NOT NULL;";
                //cmd.ExecuteNonQuery();

                foreach (BlockedURL u in blockedurls)
                {
                    cmd.CommandText = "INSERT INTO BlockedURLCat (BlockedURL,BlockedCat) VALUES ('" + u.blockedURL.ToString() + "', null);";                
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
