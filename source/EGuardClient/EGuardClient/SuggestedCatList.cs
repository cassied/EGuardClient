using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class SuggestedCatList 
    {
        private List<SuggestedCat> suggestedcats;

        public delegate void ChangeHandler(SuggestedCatList suggestedcats);
        public event ChangeHandler Changed;

        public SuggestedCatList()
        {
            suggestedcats= new List<SuggestedCat>();
        }

        public int Count
        {
            get
            {
                return suggestedcats.Count;
            }
        }

        public SuggestedCat this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= suggestedcats.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return suggestedcats[i];
            }
        }

        public SuggestedCat this[string suggestedcat]
        {
            get
            {
                foreach (SuggestedCat u in suggestedcats)
                {
                    if (u.suggestedCat == suggestedcat)
                        return u;
                }
                return null;
            }
        }

        public void Fill()
        {
            suggestedcats = SuggestedCatDB.GetSuggestedCats();
        }

    

        public void Add(SuggestedCat suggestedcat)
        {
            suggestedcats.Add(suggestedcat);
            Changed(this);
        }

        public void Add(string suggestedcat)
        {
            SuggestedCat u = new SuggestedCat(suggestedcat);
            suggestedcats.Add(u);
            Changed(this);
        }

        public void Save()
        {
            SuggestedCatDB.SaveSuggestedCats(suggestedcats);

        }
        public void Remove(SuggestedCat suggestedcat)
        {
            suggestedcats.Remove(suggestedcat);
            Changed(this);
        }

        public static SuggestedCatList operator + (SuggestedCatList ul, SuggestedCat u)
        {
            ul.Add(u);
            return ul;
        }

        public static SuggestedCatList operator - (SuggestedCatList ul, SuggestedCat u)
        {
            ul.Remove(u);
            return ul;
        }
    }
}
