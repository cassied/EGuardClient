using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EGuardClient
{
    public partial class frmControlPanel : Form
    {
        public frmControlPanel()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvBlockedURLs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblURLs_Click(object sender, EventArgs e)
        {

        }

        void BlacklistClick(object sender, EventArgs e)
        {
            Blacklist bl = new Blacklist();
            bl.ShowDialog();
        }

        void WhitelistClick(object sender, EventArgs e)
        {
            Whitelist wl = new Whitelist();
            wl.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BlacklistWords b2 = new BlacklistWords();
            b2.ShowDialog();
        }

        private void WhitelistWords(object sender, EventArgs e)
        {
            WhitelistWords w2 = new WhitelistWords();
            w2.ShowDialog();
        }
    }
}
