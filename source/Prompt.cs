using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EGuardClient
{
    public static class Prompt
    {
        public static List<string> ShowDialog(string text1,string text2, string caption)
        {
            List<string> values = new List<string>();

            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 500;
            prompt.Text = caption;
            Label textLabel1 = new Label() { Left = 50, Top = 20, Text = text1 };
            TextBox inputBox1 = new TextBox() { Left = 150, Top = 20, Width = 100 };
            Label textLabel2 = new Label() { Left = 50, Top = 50, Text = text2 };
            TextBox inputBox2 = new TextBox() { Left = 150, Top = 50, Width = 100 };
            inputBox2.PasswordChar = '*';
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel1);
            prompt.Controls.Add(textLabel2);
            prompt.Controls.Add(inputBox1);
            prompt.Controls.Add(inputBox2);
            prompt.ShowDialog();

            values.Add(inputBox1.Text);
            values.Add(inputBox2.Text);

            return values;
 
        }
    }
}
