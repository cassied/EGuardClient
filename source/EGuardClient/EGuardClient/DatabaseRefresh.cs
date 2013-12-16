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
    public static class DatabaseRefresh
    {
        private const string filePath = @"C:\Eguard\dst";

        public static void DeleteFile()
        {

            string[] txtList = Directory.GetFiles(filePath, "*.txt");
            foreach (string f in txtList)
            {
                File.Delete(f);
            }

        }

        public static void Update()
        {
            int id=1;
            string url;
            string date;
            string version;
            string rank;
            string category;
            string urlscol;

            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            //Clear suggested URLs in preparation for refresh
            //Per web team (12/15/2013), this is a merge not a replacement
            //cmd.CommandText = "DELETE FROM URLs;";

            try
            {
                cmd.Connection.Open();
                //cmd.ExecuteNonQuery();


                //Get web server file for update
                var reader = new StreamReader(File.OpenRead(@"C:\Eguard\dst\NewUpdate.txt"));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    url = values[0];
                    date = values[1];
                    version = values[2];
                    rank = values[3];
                    category = values[4];
                    urlscol = values[5];

                    cmd.CommandText = "INSERT INTO URLs (ID, URL, Date, Version, Rank, Category, URLscol) VALUES('" + id + "','" + url + "','" + date + "','" + version + "','" + rank + "','" + category + "','" + urlscol + "');";
                    cmd.ExecuteNonQuery();



                    id = id + 1;
                }

                reader.Close();
                reader.Dispose();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }
            
        }


    }
}
