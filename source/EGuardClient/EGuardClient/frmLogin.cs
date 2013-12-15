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
    public partial class EGuardClientLogin : Form
    {
        public EGuardClientLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean authenticated = false;
            UserRec u = new UserRec();
            authenticated = u.authenticateUser(txtUserName.Text, txtPassword.Text);

            if (authenticated == true)
            {
                //Make an update call to the web server
                //Update local database
                //connect to java program???? to get NewUpdate.txt which they store in C:\EGuard\dst


                //call Database Refresh
                DatabaseRefresh.Update();

                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
            }
            else
            {            
                lblMessage.Text = "Login Failed. Please try again.";
                lblMessage.Visible = true;
            }

        }

        private void EGuardClientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
