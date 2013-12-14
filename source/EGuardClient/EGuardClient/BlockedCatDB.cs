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
    public static class BlockedCatDB
    {
        private const string conStr = "Data Source=|DataDirectory|\\EGuard.sdf";

        public static List<BlockedCat> GetBlockedCats()
        {
          
            List<BlockedCat> blockedcats = new List<BlockedCat>();

            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT CategoryName FROM BlockedCat WHERE CategoryName IS NOT NULL ORDER BY CategoryName;";
            
            cmd.Connection = connection;

            cmd.Connection.Open();
            SqlCeDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                BlockedCat blockedcat = new BlockedCat();
                blockedcat.blockedCat = rdr.GetValue(0).ToString();
                blockedcats.Add(blockedcat);
            }

            cmd.Connection.Close();
            cmd.Connection.Dispose();
            cmd.Dispose();
            return blockedcats;



        }

        public static void DeleteBlockedCat(BlockedCat u)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;



            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "DELETE FROM BlockedCat WHERE CategoryName='" + u.blockedCat + "';";
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        public static void SaveBlockedCat(BlockedCat u)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String url = string.Empty;

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "INSERT INTO BlockedCat (CategoryName) VALUES ('" + u.blockedCat + "');";                
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
               
          }

        public static void SaveBlockedCats(List<BlockedCat> blockedcats)
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

                foreach (BlockedCat u in blockedcats)
                {
                    cmd.CommandText = "INSERT INTO BlockedCat (CategoryName) VALUES ('"+u.blockedCat.ToString() + "');";                
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
