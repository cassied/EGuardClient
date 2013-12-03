using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class SuggestedURLList 
    {
        private List<SuggestedURL> suggestedurls;

        public delegate void ChangeHandler(SuggestedURLList suggestedurls);
        public event ChangeHandler Changed;

        public SuggestedURLList()
        {
            suggestedurls = new List<SuggestedURL>();
        }

        public int Count
        {
            get
            {
                return suggestedurls.Count;
            }
        }

        public SuggestedURL this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= suggestedurls.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return suggestedurls[i];
            }
        }

        public SuggestedURL this[string suggestedurl]
        {
            get
            {
                foreach (SuggestedURL u in suggestedurls)
                {
                    if (u.suggestedURL == suggestedurl)
                        return u;
                }
                return null;
            }
        }

        public void Fill()
        {
            suggestedurls = SuggestedURLDB.GetSuggestedURLs();
        }

    

        public void Add(SuggestedURL suggestedurl)
        {
            suggestedurls.Add(suggestedurl);
            Changed(this);
        }

        public void Add(string suggestedurl)
        {
            SuggestedURL u = new SuggestedURL(suggestedurl);
            suggestedurls.Add(u);
            Changed(this);
        }

        public void Save()
        {
            SuggestedURLDB.SaveSuggestedURLs(suggestedurls);

        }
        public void Remove(SuggestedURL suggestedurl)
        {
            suggestedurls.Remove(suggestedurl);
            Changed(this);
        }

        public static SuggestedURLList operator + (SuggestedURLList ul, SuggestedURL u)
        {
            ul.Add(u);
            return ul;
        }

        public static SuggestedURLList operator - (SuggestedURLList ul, SuggestedURL u)
        {
            ul.Remove(u);
            return ul;
        }
    }
}
