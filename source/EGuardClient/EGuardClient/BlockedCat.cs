using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class BlockedCat
    {
        private string blockedcat;

        public BlockedCat() { }

        public BlockedCat(string blockedcat)
        {
            this.blockedCat = blockedcat;
        }

        public string blockedCat
        {
            get { return blockedcat; }
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Maximum length of URL is 100 characters.");
                this.blockedcat = value;
            }
        }

        public string GetDisplayText()
        {
            return blockedcat;
        }
    }
}
