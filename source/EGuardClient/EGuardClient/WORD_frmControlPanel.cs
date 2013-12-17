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



        private void btnUnblockWord_Click(object sender, EventArgs e)
        {
            if (lvBlockedWords.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvBlockedWords.SelectedItems.Count; i++)
                {
                    BlockedWord u = new BlockedWord();
                    u.blockedword = lvBlockedWords.SelectedItems[i].ToString();
                    blockedwords.Delete(u);

                }
            }
            blockedwords.Fill();
            FillBlockedWordListBox();

        }


        private void AddWord_click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtNewWord.Text.ToString())))
            {
                BlockedWord u = new BlockedWord();
                u.blockedword = txtNewWord.Text.ToString();
                blockedwords.Save(u);
            }
            else
            {
                MessageBox.Show("You must specify a new word to block.");
            }
            blockedwords.Fill();
            FillBlockedWordListBox();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnRemoveBlock_Click(object sender, EventArgs e)
        {
            if (lvBlockedWords.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvBlockedWords.SelectedItems.Count; i++)
                {
                    BlockedWord u = new BlockedWord();
                    u.blockedword = lvBlockedWords.SelectedItems[i].ToString();
                    blockedwords.Delete(u);

                }


            }
            blockedwords.Fill();
            FillBlockedWordListBox();
        }

      


    }
    
}
