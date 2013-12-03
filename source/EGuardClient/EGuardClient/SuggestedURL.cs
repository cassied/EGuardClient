using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class SuggestedURL
    {
        private string suggestedurl;

        public SuggestedURL() { }

        public SuggestedURL(string suggestedurl)
        {
            this.suggestedURL = suggestedurl;
        }

        public string suggestedURL
        {
            get { return suggestedurl; }
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Maximum length of URL is 100 characters.");
                this.suggestedurl = value;
            }
        }

        public string GetDisplayText()
        {
            return suggestedurl;
        }
    }
}
