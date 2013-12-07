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
using System.Data;


namespace EGuardClient
{
    public partial class frmControlPanel : Form
    {
        public frmControlPanel()
        {
            InitializeComponent();
        }

        private BlockedURLList blockedurls = new BlockedURLList();
        private SuggestedURLList suggestedurls = new SuggestedURLList();
        private BlockedCatList blockedcats = new BlockedCatList();
        private SuggestedCatList suggestedcats = new SuggestedCatList();

        private void frmControlPanel_Load(object sender, EventArgs e)
        {
            blockedurls.Changed += new BlockedURLList.ChangeHandler(HandleBlockedChange);
            suggestedurls.Changed += new SuggestedURLList.ChangeHandler(HandleSuggestedChange);
            blockedcats.Changed += new BlockedCatList.ChangeHandler(HandleBlockedCatChange);
            suggestedcats.Changed += new SuggestedCatList.ChangeHandler(HandleSuggestedCatChange);


            blockedurls.Fill();
            FillBlockedURLListBox();
            suggestedurls.Fill();
            FillSuggestedURLListBox();

            blockedcats.Fill();
            FillBlockedCatListBox();
            suggestedcats.Fill();
            FillSuggestedCatListBox();

        }

        private void FillBlockedURLListBox()
        {
            BlockedURL u;

            lvBlockedURLs.Items.Clear();
            for (int i = 0; i < blockedurls.Count; i++)
            {          
                u = blockedurls[i];
                lvBlockedURLs.Items.Add(u.GetDisplayText());
            }
        }

       
        private void HandleBlockedChange(BlockedURLList blockedurls)
        {
            blockedurls.Save();
            FillBlockedURLListBox();

        }

        private void FillSuggestedURLListBox()
        {
            SuggestedURL u;

            lvSuggestedURLs.Items.Clear();

            for (int i = 0; i < suggestedurls.Count; i++)
            {
                u = suggestedurls[i];
                lvSuggestedURLs.Items.Add(u.GetDisplayText());
            }
        }

        private void HandleSuggestedChange(SuggestedURLList suggestedurls)
        {
            suggestedurls.Save();
            FillSuggestedURLListBox();
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
        private void btnBlock_Click(object sender, EventArgs e)
        {
            int i = 0;
            BlockedURL u = new BlockedURL();
            u.blockedURL = lvSuggestedURLs.SelectedItems[i].ToString();
            blockedurls.Save(u);
            blockedurls.Fill();
            FillBlockedURLListBox();
            suggestedurls.Fill();
            FillSuggestedURLListBox();

            String path = @"C:\Windows\System32\drivers\etc\hosts";
            StreamWriter sw = new StreamWriter(path, true);
            string blacklistedURL = "\n127.0.0.1 " + u.blockedURL;
            String sitetoblock = blacklistedURL;
            sw.Write(sitetoblock);
            sw.Close();
            MessageBox.Show("The URL has been added to the Blacklist.");

        }
        private void btnRemoveBlock_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvBlockedURLs.SelectedItems.Count; i++)
            {
                BlockedURL u = new BlockedURL();
                u.blockedURL = lvBlockedURLs.SelectedItems[i].ToString();
                //blockedurls -= u;
                blockedurls.Delete(u);

                string text = File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts");
                text = text.Replace("127.0.0.1 " + u.blockedURL, string.Empty);
                File.WriteAllText(@"C:\Windows\System32\drivers\etc\hosts", text);
                MessageBox.Show("The URL has been removed from the Blacklist.");
            }

            blockedurls.Fill();
            FillBlockedURLListBox();
            suggestedurls.Fill();
            FillSuggestedURLListBox();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            lvBlockedURLs.Items.Clear();
            this.Close();
            //lvBlockedURLs.Items.Clear();
            //this.Hide();
            //Whitelist wl = new Whitelist();
            //wl.Show();

            
            
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

        private void btnAddURL_Click(object sender, EventArgs e)
        {
            int i = 0;
            BlockedURL u = new BlockedURL();
            u.blockedURL = txtNewURL.Text.ToString();
            blockedurls.Save(u);
            blockedurls.Fill();
            FillBlockedURLListBox();
            //suggestedurls.Fill();
            FillSuggestedURLListBox();

            String path = @"C:\Windows\System32\drivers\etc\hosts";
            StreamWriter sw = new StreamWriter(path, true);
            string blacklistedURL = "\n127.0.0.1 " + u.blockedURL;
            String sitetoblock = blacklistedURL;
            sw.Write(sitetoblock);
            sw.Close();
            MessageBox.Show("The new URL has been added to the Blacklist.");
        }


    }
}
