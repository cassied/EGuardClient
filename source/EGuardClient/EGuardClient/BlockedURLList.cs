using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EGuardClient
{
    public class BlockedURLList 
    {
        private List<BlockedURL> blockedurls;

        public delegate void ChangeHandler(BlockedURLList blockedurls);
        public event ChangeHandler Changed;

        public BlockedURLList()
        {
            blockedurls = new List<BlockedURL>();
        }

        public int Count
        {
            get
            {
                return blockedurls.Count;
            }
        }

        public BlockedURL this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= blockedurls.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return blockedurls[i];
            }
        }

        public BlockedURL this[string blockedurl]
        {
            get
            {
                foreach (BlockedURL u in blockedurls)
                {
                    if (u.blockedURL == blockedurl)
                        return u;
                }
                return null;
            }
        }

        public void Fill()
        {
            blockedurls = BlockedURLDB.GetBlockedURLs();
        }

        public void Save()
        {
            BlockedURLDB.SaveBlockedURLs(blockedurls);

        }

        public void Save(BlockedURL blockedURL)
        {
            BlockedURLDB.SaveBlockedURL(blockedURL);
        }
        public void Delete(BlockedURL blockedURL)
        {
            BlockedURLDB.DeleteBlockedURL(blockedURL);      
        }

        public void Add(BlockedURL blockedurl)
        {
            blockedurls.Add(blockedurl);
            Changed(this);
        }

        public void Add(string blockedurl)
        {
            string[] values;
            values = blockedurl.ToString().Split('-');
            string url = values[0];
            string cat = values[1];

            BlockedURL u = new BlockedURL(blockedurl);
            blockedurls.Add(u);
            Changed(this);
        }

        
        public void Remove(BlockedURL blockedurl)
        {
            blockedurls.Remove(blockedurl);
            Changed(this);
        }

        public static BlockedURLList operator + (BlockedURLList ul, BlockedURL u)
        {
            ul.Add(u);
            return ul;
        }

        public static BlockedURLList operator - (BlockedURLList ul, BlockedURL u)
        {
            ul.Remove(u);
            return ul;
        }
    }
}
