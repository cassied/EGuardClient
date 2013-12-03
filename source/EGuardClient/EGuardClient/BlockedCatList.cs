using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EGuardClient
{
    public class BlockedCatList 
    {
        private List<BlockedCat> blockedcats;

        public delegate void ChangeHandler(BlockedCatList blockedcats);
        public event ChangeHandler Changed;

        public BlockedCatList()
        {
            blockedcats = new List<BlockedCat>();
        }

        public int Count
        {
            get
            {
                return blockedcats.Count;
            }
        }

        public BlockedCat this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= blockedcats.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return blockedcats[i];
            }
        }

        public BlockedCat this[string blockedcat]
        {
            get
            {
                foreach (BlockedCat u in blockedcats)
                {
                    if (u.blockedCat == blockedcat)
                        return u;
                }
                return null;
            }
        }

        public void Fill()
        {
            blockedcats = BlockedCatDB.GetBlockedCats();
        }

        public void Save()
        {
            BlockedCatDB.SaveBlockedCats(blockedcats);

        }

        public void Save(BlockedCat blockedCat)
        {
            BlockedCatDB.SaveBlockedCat(blockedCat);
        }
        public void Delete(BlockedCat blockedCat)
        {
            BlockedCatDB.DeleteBlockedCat(blockedCat);      
        }

        public void Add(BlockedCat blockedcat)
        {
            blockedcats.Add(blockedcat);
            Changed(this);
        }

        public void Add(string blockedcat)
        {
            BlockedCat u = new BlockedCat(blockedcat);
            blockedcats.Add(u);
            Changed(this);
        }

        
        public void Remove(BlockedCat blockedcat)
        {
            blockedcats.Remove(blockedcat);
            Changed(this);
        }

        public static BlockedCatList operator + (BlockedCatList cl, BlockedCat c)
        {
            cl.Add(c);
            return cl;
        }

        public static BlockedCatList operator - (BlockedCatList cl, BlockedCat c)
        {
            cl.Remove(c);
            return cl;
        }
    }
}
