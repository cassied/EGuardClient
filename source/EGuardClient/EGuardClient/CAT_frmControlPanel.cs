using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.SqlClient;



namespace EGuardClient
{
    public partial class CAT_frmControlPanel : Form
    {
        public CAT_frmControlPanel()
        {
            InitializeComponent();
        }
        private BlockedCatList blockedcats = new BlockedCatList();
        private SuggestedCatList suggestedcats = new SuggestedCatList();

        private void frmControlPanel_Load(object sender, EventArgs e)
        {
            blockedcats.Changed += new BlockedCatList.ChangeHandler(HandleBlockedCatChange);
            suggestedcats.Changed += new SuggestedCatList.ChangeHandler(HandleSuggestedCatChange);


            blockedcats.Fill();
            FillBlockedCatListBox();
            suggestedcats.Fill();
            FillSuggestedCatListBox();

        }

        private void FillBlockedCatListBox()
        {
            BlockedCat u;

            lvBlockedCats.Items.Clear();
            for (int i = 0; i < blockedcats.Count; i++)
            {
                u = blockedcats[i];
                lvBlockedCats.Items.Add(u.GetDisplayText());
            }
        }

        private void HandleBlockedCatChange(BlockedCatList blockedcats)
        {
            blockedcats.Save();
            FillBlockedCatListBox();

        }

        private void FillSuggestedCatListBox()
        {
            SuggestedCat u;

            lvSuggestedCats.Items.Clear();

            for (int i = 0; i < suggestedcats.Count; i++)
            {
                u = suggestedcats[i];
                lvSuggestedCats.Items.Add(u.GetDisplayText());
            }
        }

        private void HandleSuggestedCatChange(SuggestedCatList suggestedcats)
        {
            suggestedcats.Save();
            FillSuggestedCatListBox();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
           // lvBlockedURLs.Items.Clear();
            this.Close();
            //lvBlockedURLs.Items.Clear();
            //this.Hide();

        }

        private void btnBlockCat_Click(object sender, EventArgs e)
        {
            int i = 0;
            BlockedCat u = new BlockedCat();
            u.blockedCat = lvSuggestedCats.SelectedItems[i].ToString();
            blockedcats.Save(u);
            blockedcats.Fill();
            FillBlockedCatListBox();
            suggestedcats.Fill();
            FillSuggestedCatListBox();

        }

        private void btnUnblockCat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvBlockedCats.SelectedItems.Count; i++)
            {
                BlockedCat u = new BlockedCat();
                u.blockedCat = lvBlockedCats.SelectedItems[i].ToString();
                blockedcats.Delete(u);


            }

            blockedcats.Fill();
            FillBlockedCatListBox();
            suggestedcats.Fill();
            FillSuggestedCatListBox();
        }

        private void lvSuggestedURLs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddCat_click(object sender, EventArgs e)
        {
            int i = 0;
            BlockedCat u = new BlockedCat();
            u.blockedCat = txtNewCat.Text.ToString();
            blockedcats.Save(u);
            blockedcats.Fill();
            FillBlockedCatListBox();
            suggestedcats.Fill();
            FillSuggestedCatListBox();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }


    }
}
