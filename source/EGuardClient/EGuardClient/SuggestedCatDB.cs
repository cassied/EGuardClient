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
    public static class SuggestedCatDB
    {
        private const string conStr = "Data Source=|DataDirectory|\\EGuard.sdf; Persist Security Info=False;";

        public static List<SuggestedCat> GetSuggestedCats()
        {
          
            List<SuggestedCat> suggestedCats = new List<SuggestedCat>();

            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            //Exclude Suggested Cats that are already being blocked
            cmd.CommandText = "SELECT DISTINCT Category FROM URLs LEFT OUTER JOIN BlockedCat B ON B.CategoryName=URLs.Category WHERE B.CategoryName IS NULL ORDER BY Category;";
            
            cmd.Connection = connection;

            cmd.Connection.Open();
            SqlCeDataReader rdr = cmd.ExecuteReader();
 

            while (rdr.Read())
            {
                SuggestedCat suggestedCat = new SuggestedCat();
                suggestedCat.suggestedCat = rdr.GetValue(0).ToString();
                suggestedCats.Add(suggestedCat);
            }

            cmd.Connection.Close();
            cmd.Connection.Dispose();
            cmd.Dispose();
            return suggestedCats;



        }

        public static void SaveSuggestedCats(List<SuggestedCat> suggestedCats)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String Cat = string.Empty;

            try
            {
                cmd.Connection.Open();
                foreach (SuggestedCat u in suggestedCats)
                {

                    //cmd.CommandText = "INSERT INTO Cat (BlockedCat) VALUES ('" + u.blockedCat.ToString() + "');";
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
