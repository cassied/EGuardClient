using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace EGuardClient
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class Whitelist : Form
    {
        public Whitelist()
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
            string text = File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts");
            text = text.Replace("127.0.0.1 " + whitelistURL.Text, string.Empty);
            File.WriteAllText(@"C:\Windows\System32\drivers\etc\hosts", text);
            MessageBox.Show("The URL has been removed from the Blacklist.");
        }

        void Button2Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pattern = "127";
            List<string> result = new List<string>();
            using (var reader = new StreamReader(@"C:\Windows\System32\drivers\etc\hosts"))
            {
                string currentLine;
                while ((currentLine = reader.ReadLine()) != null)
                {
                    if (currentLine.Contains(pattern))
                    {
                        result.Add(currentLine);
                    }
                }
            }

            listBox1.DataSource = result;
        }

        private void whitelistURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
