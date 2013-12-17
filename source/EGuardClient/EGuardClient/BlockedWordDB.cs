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
    public class BlockedWordDB
    {
       // private const string conStr = "Data Source=|DataDirectory|\\EGuard.sdf";

        
        public static List<BlockedWord> GetBlockedWords()
        {
          
            List<BlockedWord> blockedwords = new List<BlockedWord>();

            //string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + @"\BAD_WORD_LIST.txt");
            var reader = new StreamReader(File.OpenRead(Application.StartupPath + @"\BAD_WORD_LIST.txt"));

            
            while (!reader.EndOfStream)
            {
                 var line = reader.ReadLine();
                 var values = line.Split(',');

                BlockedWord blockedword = new BlockedWord();
                blockedword.blockedword = values[0];
                blockedwords.Add(blockedword);
                 
            }

            return blockedwords;
        }

        public static void DeleteBlockedWord(BlockedWord blockedword)
        {

            string filePath = Application.StartupPath + @"\BAD_WORD_LIST.txt";
            string stringToRemove = blockedword.ToString();

            List<string> readLines = new List<string>(); 

            //Read the file line-wise into List
            using (var streamReader = new StreamReader(filePath, Encoding.Default))
            {
                while (!streamReader.EndOfStream)
                {
                    readLines.Add(streamReader.ReadLine());
                }

                streamReader.Close();
                GC.Collect();
            }
  

            // If list contains stringToAdd then remove all its instances from the list; otherwise add stringToAdd to the list
            if (readLines.Contains(stringToRemove))
            {
                readLines.Remove(stringToRemove);
    
            }
            else
            {
                //readLines.Add(stringToAdd);
            }

            // Write the modified list to the file
            using (var streamWriter = new StreamWriter(filePath,true,Encoding.Default))
            {
                foreach (string line in readLines)
                {
                  
                    streamWriter.WriteLine(line);
                    
                }
                streamWriter.Close();
            }

        }
        public static void SaveBlockedWord(BlockedWord u)
        {
            SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            String url = string.Empty;

            try
            {
                //cmd.Connection.Open();
                //cmd.CommandText = "INSERT INTO BlockedCat (CategoryName) VALUES ('" + u.blockedCat + "');";                
                //cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
               
          }

        public static void SaveBlockedWords(List<BlockedWord> blockedwords)
        {
            //SqlCeConnection connection = new SqlCeConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString());
            //SqlCeCommand cmd = new SqlCeCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Connection = connection;

            //String url = string.Empty;

            //try
            //{
            //    cmd.Connection.Open();
            //    //cmd.CommandText = "DELETE FROM BlockedURLCat WHERE BlockedURL IS NOT NULL;";
            //    //cmd.ExecuteNonQuery();

            //    foreach (BlockedWord u in blockedwords)
            //    {
            //        cmd.CommandText = "INSERT INTO BlockedCat (CategoryName) VALUES ('"+u.blockedWord.ToString() + "');";                
            //        cmd.ExecuteNonQuery();
            //   }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
      
            //}
               
          }

    }
    }

