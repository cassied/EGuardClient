using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class BlockedURL
    {
        private string blockedurl;

        public BlockedURL() { }

        public BlockedURL(string blockedurl)
        {
            this.blockedURL = blockedurl;

        }

        public string blockedURL
        {
            get { return blockedurl; }
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Maximum length of URL is 100 characters.");
                this.blockedurl = value;
            }
        }

        public string GetDisplayText()
        {
            return blockedurl;
        }
    }
}
