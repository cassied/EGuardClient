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
       
        public static List<BlockedWord> GetBlockedWords()
        {
          
            List<BlockedWord> blockedwords = new List<BlockedWord>();
            
            var reader = new StreamReader(File.OpenRead(Application.StartupPath + @"\BAD_WORD_LIST.txt"));

            
            while (!reader.EndOfStream)
            {
                 var line = reader.ReadLine();
                 var values = line.Split(',');

                BlockedWord blockedword = new BlockedWord();
                blockedword.blockedword = values[0];
                blockedwords.Add(blockedword);
                 
            }
            reader.Close();

            return blockedwords;
        }

        public static void DeleteBlockedWord(List<BlockedWord> blockedword)
        {

            using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\BAD_WORD_LIST.txt"))
            {
                foreach (BlockedWord u in blockedword)
                {
                    sw.WriteLine(u.blockedword);

                }
                sw.Close();
            }


        }
        public static void SaveBlockedWord(List<BlockedWord> blockedword)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\BAD_WORD_LIST.txt"))
                {
                    foreach (BlockedWord u in blockedword)
                    {
                        sw.WriteLine(u.blockedword);

                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

               
          }

        public static void SaveBlockedWords(List<BlockedWord> blockedwords)
        {

               
         }

    }
    }

