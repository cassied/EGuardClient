﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace EGuardClient
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class BlacklistWords : Form
    {
        public BlacklistWords()
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
            string blacklistedWord = blacklistWord.Text;
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
