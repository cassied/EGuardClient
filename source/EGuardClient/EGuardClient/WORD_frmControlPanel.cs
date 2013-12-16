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
        private SuggestedWordList suggestedcats = new SuggestedWordList();

        private void WORD_frmControlPanel_Load(object sender, EventArgs e)
        {
            blockedwords.Changed += new BlockedWordList.ChangeHandler(HandleBlockedCatChange);
            suggestedwords.Changed += new SuggestedWordList.ChangeHandler(HandleSuggestedCatChange);


            blockedwordsCatListBox();
            suggestedwords.Fill();
            FillSuggestedWordListBox();

        }

        private void FillBlockedCatListBox()
        {
            BlockedCat u;

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

        private void FillSuggestedWlordListBox()
        {
            SuggestedWords u;

            lvSuggestedWords.Items.Clear();

            for (int i = 0; i < suggestedwords.Count; i++)
            {
                u = suggestedwords[i];
                lvSuggestedWords.Items.Add(u.GetDisplayText());
            }
        }

        private void HandleSuggestedWordChange(SuggestedWordList suggestedcats)
        {
            suggestedwords.Save();
            FillSuggestedWordListBox();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
           // lvBlockedURLs.Items.Clear();
            this.Close();
            //lvBlockedURLs.Items.Clear();
            //this.Hide();

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            int i = 0;
            BlockedWords u = new BlockedWords();
            if (lvSuggestedWords.SelectedItems.Count > 0)
            {
                u.blockedWords = lvSuggestedWords.SelectedItems[i].ToString();
                blockedwords.Save(u);
            }
            blockedwords.Fill();
            FillBlockedWordListBox();
            suggestedwords.Fill();
            FillSuggestedWordListBox();

        }

        private void btnUnblockWord_Click(object sender, EventArgs e)
        {
            if (lvBlockedWords.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvBlockedWords.SelectedItems.Count; i++)
                {
                    BlockedWord u = new BlockedWord();
                    u.blockedWord = lvBlockedWord.SelectedItems[i].ToString();
                    blockedword.Delete(u);


                }
            }
            blockedwords.Fill();
            FillBlockedWordListBox();
            suggestedwords.Fill();
            FillSuggestedWordListBox();
        }


        private void AddWord_click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtNewWord.Text.ToString())))
            {
                BlockedWord u = new BlockedWord();
                u.blockedWord = txtNewWord.Text.ToString();
                blockedwords.Save(u);
            }
            else
            {
                MessageBox.Show("You must specify a new word to block.");
            }
            blockedwords.Fill();
            FillBlockedWordListBox();
            suggestedwords.Fill();
            FillSuggestedWordListBox();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }


    }
    
}
