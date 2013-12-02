/*
 * Created by SharpDevelop.
 * User: c623205
 * Date: 11/6/2013
 * Time: 2:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace EGuardClient
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class Blacklist : Form
    {
        public Blacklist()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void Button1Click(object sender, EventArgs e)
        {
            String path = @"C:\Windows\System32\drivers\etc\hosts";
            StreamWriter sw = new StreamWriter(path, true);
            string blacklistedURL = "\n127.0.0.1 " + blacklistURL.Text;
            String sitetoblock = blacklistedURL;
            sw.Write(sitetoblock);
            sw.Close();
            MessageBox.Show("The URL has been added to the Blacklist.");
        }

        void TextBox1TextChanged(object sender, EventArgs e)
        {

        }

        void Button2Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3Click(object sender, EventArgs e)
        {

        }

        private void Blacklist_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void blacklistURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
