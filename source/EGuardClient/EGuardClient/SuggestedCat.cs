using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class SuggestedCat
    {
        private string suggestedcat;

        public SuggestedCat() { }

        public SuggestedCat(string suggestedcat)
        {
            this.suggestedCat = suggestedcat;
        }

        public string suggestedCat
        {
            get { return suggestedcat; }
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Maximum length of URL is 100 characters.");
                this.suggestedcat = value;
            }
        }

        public string GetDisplayText()
        {
            return suggestedcat;
        }
    }
}
