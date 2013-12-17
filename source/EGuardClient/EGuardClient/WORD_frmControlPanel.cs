using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EGuardClient
{
    public partial class WORD_frmControlPanel : Form
    {
        public WORD_frmControlPanel()
        {
            InitializeComponent();
        }
        
        private BlockedWordList blockedwords = new BlockedWordList();

        private void WORD_frmControlPanel_Load(object sender, EventArgs e)
        {
            blockedwords.Changed += new BlockedWordList.ChangeHandler(HandleBlockedWordChange);
            blockedwords.Changed -= new BlockedWordList.ChangeHandler(HandleBlockedWordChange);

            blockedwords.Fill();
            FillBlockedWordListBox();
 

        }

        private void FillBlockedWordListBox()
        {
            BlockedWord u;

            lvBlockedWords.Items.Clear();
            for (int i = 0; i < blockedwords.Count; i++)
            {
                u = blockedwords[i];
                lvBlockedWords.Items.Add(u.GetDisplayText());
            }
        }

        private void HandleBlockedWordChange(BlockedWordList blockedwords)
        {
            blockedwords.Save();
            FillBlockedWordListBox();

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            
           // lvBlockedURLs.Items.Clear();
            this.Close();
            //lvBlockedURLs.Items.Clear();
            //this.Hide();

        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnRemoveBlock_Click(object sender, EventArgs e)
        {
       
            List<BlockedWord> bl = new List<BlockedWord>();
            List<BlockedWord> bl2 = new List<BlockedWord>();

            for (int i = 0; i < lvBlockedWords.SelectedItems.Count; i++)
            {
                BlockedWord u = new BlockedWord();
                u.blockedword = lvBlockedWords.SelectedItems[i].ToString();
                bl.Add(u);

            }
            foreach (BlockedWord u in bl)
            {
                lvBlockedWords.Items.Remove(u.blockedword);
  
            }
            
            for (int i=0; i < lvBlockedWords.Items.Count; i++)
            {
                BlockedWord u = new BlockedWord();
                u.blockedword = lvBlockedWords.Items[i].ToString();
                bl2.Add(u);

            }

            blockedwords.Delete(bl2);

            blockedwords.Fill();
            FillBlockedWordListBox();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            List<BlockedWord> bl = new List<BlockedWord>();
            for (int i = 0; i < lvBlockedWords.Items.Count; i++)
            {
                BlockedWord u = new BlockedWord();
                u.blockedword = lvBlockedWords.Items[i].ToString();
                bl.Add(u);
            }

            if (!(string.IsNullOrEmpty(txtNewWord.Text.ToString())))
            {
                BlockedWord u = new BlockedWord();
                u.blockedword = txtNewWord.Text.ToString();
                bl.Add(u);
                blockedwords.Save(bl);

            }
            else
            {
                MessageBox.Show("You must specify a new word to block.");
            }
            blockedwords.Fill();
            FillBlockedWordListBox();

        }

      


    }
    
}
