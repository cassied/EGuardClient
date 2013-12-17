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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnManageURLs_Click(object sender, EventArgs e)
        {
            URL_frmControlPanel frmURL = new URL_frmControlPanel();
            frmURL.Show();
            this.Hide();

        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageCATs_Click_1(object sender, EventArgs e)
        {
            CAT_frmControlPanel frmCAT = new CAT_frmControlPanel();
            frmCAT.Show();
            this.Hide();
        }

        private void btnManageTC_Click_1(object sender, EventArgs e)
        {
            TC_frmControlPanel frmTC = new TC_frmControlPanel();
            frmTC.Show();
            this.Hide();

        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            WORD_frmControlPanel frmWORD = new WORD_frmControlPanel();
            frmWORD.Show();
            this.Hide();
        }
    }
}
