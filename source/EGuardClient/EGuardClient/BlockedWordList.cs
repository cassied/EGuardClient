using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGuardClient
{
    public class BlockedWordList
    {
        private List<BlockedWord> blockedwords;

        public delegate void ChangeHandler(BlockedWordList blockedwords);
        public event ChangeHandler Changed;

        public BlockedWordList()
        {
            blockedwords = new List<BlockedWord>();
        }

        public int Count
        {
            get
            {
                return blockedwords.Count();
            }
        }

        public BlockedWord this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= blockedwords.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return blockedwords[i];
            }
        }

        public BlockedWord this[string blockedword]
        {
            get
            {
                foreach (BlockedWord u in blockedwords)
                {
                    if (u.blockedword == blockedword)
                        return u;
                }
                return null;
            }
        }

        public void Fill()
        {
            blockedwords = BlockedWordDB.GetBlockedWords();

        }

        public void Save()
        {
            BlockedWordDB.SaveBlockedWords(blockedwords);

        }

        public void Save(List<BlockedWord> blockedWord)
        {
            BlockedWordDB.SaveBlockedWord(blockedWord);
        }
        public void Delete(List<BlockedWord> blockedWord)
        {
            BlockedWordDB.DeleteBlockedWord(blockedWord);      
        }

        public void Add(BlockedWord blockedword)
        {
            blockedwords.Add(blockedword);
            Changed(this);
        }

        public void Add(string blockedword)
        {
            BlockedWord u = new BlockedWord(blockedword);
            blockedwords.Add(u);
            Changed(this);
        }

        
        public void Remove(BlockedWord blockedword)
        {
            blockedwords.Remove(blockedword);
            Changed(this);
        }

        public static BlockedWordList operator + (BlockedWordList wl, BlockedWord w)
        {
            wl.Add(w);
            return wl;
        }

        public static BlockedWordList operator - (BlockedWordList wl, BlockedWord w)
        {
            wl.Remove(w);
            return wl;
        }
    }
 }

