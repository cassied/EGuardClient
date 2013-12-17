using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class BlockedWord
    {
        private string blockedWord;

        public BlockedWord() { }

         public BlockedWord(string word)
        {
            this.blockedWord = word;
        }

         public string blockedword
         {
             get { return blockedWord; }
             set
             {
                 if (value.Length > 100)
                     throw new ArgumentException("Maximum length of word is 100 characters.");
                 this.blockedWord = value;
             }
         }

         public string GetDisplayText()
         {
             return blockedWord;
         }
    }
}
